using System;
using Microsoft.Data.SqlClient;

namespace Sales_Inventory_Management
{
    public class BackupReminderService
    {
        public static bool IsBackupDue()
        {
            string query = @"
                SELECT TOP 1 BackupDate
                FROM dbo.BackupHistory
                ORDER BY BackupDate DESC;";

            using (SqlConnection connection =
                DatabaseHelper.GetConnection())
            {
                connection.Open();

                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    object result = command.ExecuteScalar();

                    // No backup has ever been recorded.
                    if (result == null || result == DBNull.Value)
                    {
                        return true;
                    }

                    DateTime lastBackup = Convert.ToDateTime(result);

                    // A backup is due after seven days.
                    return (DateTime.Now - lastBackup).TotalDays >= 7;
                }
            }
        }
    }
}