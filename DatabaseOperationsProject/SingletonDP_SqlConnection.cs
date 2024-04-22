using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperationsProject
{
    public sealed class SingletonDP_DatabaseConnection
    {
        private static SqlConnection sqlConnection = null;
        private static readonly string connectionString = @"Data Source=DESKTOP-4OR4SUH\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
        
        static SingletonDP_DatabaseConnection()
        {
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("Coneection established successfully!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("SingletonDB: static-constructor: Connection is not established!!!");
            }
        }

        // it creates object but we cannot use it in another function
        //private SingletonDP_DatabaseConnection()
        //{
        //    try
        //    {
        //        sqlConnection = new SqlConnection(connectionString);
        //        sqlConnection.Open();
        //        Console.WriteLine("Coneection established successfully!!!");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("SingletonDB: Connection is not established!!!");
        //    }
        //}

        public static SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
