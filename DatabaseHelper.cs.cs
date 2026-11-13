using Microsoft.Data.SqlClient;

namespace Sales_Inventory_Management
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
        @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TuckShopDB;Integrated Security=True;Connect Timeout=30;";


        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
   

}
