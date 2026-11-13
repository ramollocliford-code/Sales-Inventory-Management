
using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Sales_Inventory_Management
{
    public static class OwnerAccountService
    {
        private const string ConnectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TuckShopDB;Integrated Security=True;";

        public static void CreateOwnerAccount(
            string username,
            string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required.");
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                throw new ArgumentException(
                    "Password must contain at least 8 characters.");
            PasswordHelper.CreatePasswordHash(
                password,
                out string passwordHash,
                out string passwordSalt);

            using (SqlConnection connection =
                   new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    @"INSERT INTO OwnerAccount
                      (Username, PasswordHash, PasswordSalt)
                      VALUES (@Username, @PasswordHash, @PasswordSalt);",
                    connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 50).Value =
                        username.Trim();

                    command.Parameters.Add(
                        "@PasswordHash", SqlDbType.NVarChar, 128).Value =
                        passwordHash;

                    command.Parameters.Add(
                        "@PasswordSalt", SqlDbType.NVarChar, 128).Value =
                        passwordSalt;

                    command.ExecuteNonQuery();
                }
            }
        }
        public static bool HasOwnerAccount()
        {
            using (SqlConnection connection =
                   new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    "SELECT COUNT(*) FROM OwnerAccount;",
                    connection))
                {
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        public static bool VerifyOwnerAccount(
            string username,
            string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrEmpty(password))
                return false;

            using (SqlConnection connection =
                   new SqlConnection(ConnectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(
                    @"SELECT PasswordHash, PasswordSalt
                      FROM OwnerAccount
                      WHERE Username = @Username;",
                    connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 50).Value =
                        username.Trim();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        string storedHash = reader.GetString(0);
                        string storedSalt = reader.GetString(1);

                        return PasswordHelper.VerifyPassword(
                            password, storedHash, storedSalt);
                    }
                }
            }
        }
        public static string GetUserRole(
    string username,
    string password)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrEmpty(password))
                return null;

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            SELECT PasswordHash, PasswordSalt, Role
            FROM OwnerAccount
            WHERE Username = @Username;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 50).Value =
                        username.Trim();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        string storedHash = reader.GetString(0);
                        string storedSalt = reader.GetString(1);
                        string role = reader.GetString(2);

                        bool validPassword = PasswordHelper.VerifyPassword(
                            password,
                            storedHash,
                            storedSalt);

                        return validPassword ? role : null;
                    }
                }
            }
        }
        public static bool ChangeOwnerPassword(
    string username,
    string currentPassword,
    string newPassword)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrEmpty(currentPassword) ||
                string.IsNullOrEmpty(newPassword))
            {
                throw new ArgumentException("All password fields are required.");
            }

            if (newPassword.Length < 8)
            {
                throw new ArgumentException(
                    "The new password must contain at least 8 characters.");
            }

            using (SqlConnection connection =
                   new SqlConnection(ConnectionString))
            {
                connection.Open();

                string storedHash;
                string storedSalt;

                // Retrieve the existing password credentials.
                using (SqlCommand command = new SqlCommand(
                    @"SELECT PasswordHash, PasswordSalt
              FROM OwnerAccount
              WHERE Username = @Username;",
                    connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 50).Value =
                        username.Trim();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                            return false;

                        storedHash = reader.GetString(0);
                        storedSalt = reader.GetString(1);
                    }
                }

                // Verify the current password.
                bool isValid = PasswordHelper.VerifyPassword(
                    currentPassword,
                    storedHash,
                    storedSalt);

                if (!isValid)
                    return false;

                // Generate a new password hash and salt.
                PasswordHelper.CreatePasswordHash(
                    newPassword,
                    out string newHash,
                    out string newSalt);

                // Update the database.
                using (SqlCommand command = new SqlCommand(
                    @"UPDATE OwnerAccount
              SET PasswordHash = @PasswordHash,
                  PasswordSalt = @PasswordSalt
              WHERE Username = @Username;",
                    connection))
                {
                    command.Parameters.Add(
                        "@PasswordHash", SqlDbType.NVarChar, 128).Value =
                        newHash;

                    command.Parameters.Add(
                        "@PasswordSalt", SqlDbType.NVarChar, 128).Value =
                        newSalt;

                    command.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 50).Value =
                        username.Trim();

                    return command.ExecuteNonQuery() == 1;
                }
            }
        }
        public static void CreateUser(
    string username,
    string password,
    string role)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("Username is required.");

            if (string.IsNullOrWhiteSpace(password) || password.Length < 8)
                throw new ArgumentException(
                    "Password must contain at least 8 characters.");

            if (role != "Owner" && role != "Cashier")
                throw new ArgumentException("Invalid user role.");

            PasswordHelper.CreatePasswordHash(
                password,
                out string passwordHash,
                out string passwordSalt);

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            INSERT INTO OwnerAccount
            (Username, PasswordHash, PasswordSalt, Role)
            VALUES
            (@Username, @PasswordHash, @PasswordSalt, @Role);";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@Username", SqlDbType.NVarChar, 50).Value =
                        username.Trim();

                    command.Parameters.Add(
                        "@PasswordHash", SqlDbType.NVarChar, 128).Value =
                        passwordHash;

                    command.Parameters.Add(
                        "@PasswordSalt", SqlDbType.NVarChar, 128).Value =
                        passwordSalt;

                    command.Parameters.Add(
                        "@Role", SqlDbType.NVarChar, 20).Value =
                        role;

                    command.ExecuteNonQuery();
                }
            }
        }
        public static DataTable GetAllUsers()
        {
            DataTable usersTable = new DataTable();

            using (SqlConnection connection =
                new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            SELECT Username, Role
            FROM OwnerAccount
            ORDER BY Role, Username;";

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter =
                        new SqlDataAdapter(command))
                    {
                        adapter.Fill(usersTable);
                    }
                }
            }

            return usersTable;
        }
        public static void RemoveUser(string username)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"
            DELETE FROM OwnerAccount
            WHERE Username = @Username
            AND Role = 'Cashier';";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected == 0)
                    {
                        throw new Exception(
                            "The account could not be removed. Only Cashier accounts can be removed.");
                    }
                }
            }
        }
    }
}