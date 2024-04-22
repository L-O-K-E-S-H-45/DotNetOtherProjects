using System.Collections.Generic;
using System.Data.SqlClient;

namespace DatabaseOperationsProject  // 17-4-2024
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //SqlConnection sqlConnection;
            //string connectionString = @"Data Source=DESKTOP-4OR4SUH\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";
            //try
            //{
            //    sqlConnection = new SqlConnection(connectionString);
            //    sqlConnection.Open();
            //    Console.WriteLine("Connection established successfuly!!!");

            //---- Insert
            //string insertQuery = "insert into Students(student_name, student_age) values('Smith', 43)";
            //SqlCommand insertCommand = new SqlCommand(insertQuery,sqlConnection);
            //insertCommand.ExecuteNonQuery();
            //Console.WriteLine("Student data successfully inserted into database!!!");

            //string studentName = "Miller";
            //int studentAge = 10;
            //string insertQuery = "insert into Students (student_name, student_age) values('"+studentName+"',"+ studentAge +")";
            //SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
            //insertCommand.ExecuteNonQuery();
            //Console.WriteLine("Student data successfully inserted into database!!!");

            //---- RETRIEVE
            //string displayQuery = "select * from Students";
            //SqlCommand displayCommand = new SqlCommand(displayQuery, sqlConnection);
            //SqlDataReader dataReader = displayCommand.ExecuteReader();
            //while (dataReader.Read())
            //{  // with or wothout .ToString() also works
            //    Console.WriteLine($"student_id: {dataReader.GetValue(0)}, " +
            //        $"student_name: {dataReader.GetValue(1).ToString()}, " +
            //        $"student_age: {dataReader.GetValue(2)}"); 
            //}
            //dataReader.Close();

            //---- UPDATE
            //string updateQuery = "update Students set student_age = 55 where student_id=2";
            //SqlCommand updatecommand = new SqlCommand(updateQuery, sqlConnection);
            //updatecommand.ExecuteNonQuery();
            //Console.WriteLine("student data updated successfully!!!");

            //---- DELETE
            //string studentName = "Jhon";
            ////string deleteQuery = "delete from Students where student_name = 'Jhonn'";
            //string deleteQuery = "delete from Students where student_name = '" + studentName + "'";
            //SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlConnection);
            //deleteCommand.ExecuteNonQuery();
            //Console.WriteLine("Student data deleted successfully!!!!");

            //int studentId = 10;
            //string deleteQuery = "delete from Students where student_id = " + studentId;
            //SqlCommand deleteCommand = new SqlCommand(deleteQuery,sqlConnection);
            //deleteCommand.ExecuteNonQuery();
            //Console.WriteLine("Student data deleted successfully!!!!");

            //    sqlConnection.Close();

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //--------------------------------------

            //SingletonDP_DatabaseConnection databaseConnection1 = new SingletonDP_DatabaseConnection();
            //SingletonDP_DatabaseConnection databaseConnection2 = new SingletonDP_DatabaseConnection();
            //SqlConnection sqlConnection1 = databaseConnection1.GetConnection();
            //SqlConnection sqlConnection2 = databaseConnection2.GetConnection();

            //SqlConnection sqlConnection1 = SingletonDP_DatabaseConnection.GetConnection();
            //SqlConnection sqlConnection2 = SingletonDP_DatabaseConnection.GetConnection();
            //Console.WriteLine(sqlConnection1);
            //Console.WriteLine(sqlConnection2);
            //Console.WriteLine("Are connections same: " + (sqlConnection1 == sqlConnection2));

            // ---------
            DatabaseOperations databaseOperations = new DatabaseOperations();
            //databaseOperations.Create();
            //databaseOperations.Insert();
            //databaseOperations.Retrieve();
            //databaseOperations.Update();
            //databaseOperations.Delete();

        }
    }
}
