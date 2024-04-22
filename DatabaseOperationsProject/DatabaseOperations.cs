using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseOperationsProject
{
    internal class DatabaseOperations
    {
        private SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=DESKTOP-4OR4SUH\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True";
            SqlConnection SqlConnection = null;
            try
            {
                SqlConnection = new SqlConnection(connectionString);
                SqlConnection.Open();
                Console.WriteLine("Connecton established successfully!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection is not etablished!!!");
                Console.WriteLine(ex.Message);
            }
            return SqlConnection;

        }
        internal void Create()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = SingletonDP_DatabaseConnection.GetConnection();
                if (sqlConnection != null)
                {
                    string createQuery = "create table Employees (" +
                                        "emp_id int primary key identity(1,1), " +
                                        "emp_name varchar(50) not null," +
                                        "emp_phone bigint check(emp_phone>=6000000000 and emp_phone<=9999999999)," +
                                        "emp_dob date" +
                                        ")";
                    SqlCommand createCommand = new SqlCommand(createQuery, sqlConnection);
                    createCommand.ExecuteNonQuery();
                    Console.WriteLine("Employee table created successfully!!!");
                }
                else
                    Console.WriteLine("SqlConnection is null");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        internal void Insert()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = SingletonDP_DatabaseConnection.GetConnection();
                if (sqlConnection != null)
                {
                    Console.WriteLine("Enter Employee name: ");
                    string name = Console.ReadLine();
                    //string name = "Tom";
                    Console.WriteLine("Enter Employee phone number: ");
                    long phone = long.Parse(Console.ReadLine());
                    //long phone = 6575342411;
                    Console.WriteLine("Enter Employee date of birth(YYYY-MM-DD): ");
                    //DateTime dob = DateTime.Parse("2024-5-14");  // yyyy-mm-dd
                    //string dob = "2024-5-14";
                    string dob = Console.ReadLine();

                    string insertQuery = "insert into Employees(emp_name,emp_phone,emp_dob) " +
                        "values('" + name + "'," + phone + ",'" + dob + "')";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Employee data inserted successfully!!!");
                }
                else
                    Console.WriteLine("SqlConnection is null!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        internal void Retrieve()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = SingletonDP_DatabaseConnection.GetConnection();
                if (sqlConnection != null)
                {
                    string fetchQuery = "select * from Employees";
                    SqlCommand fetchCommand = new SqlCommand(fetchQuery, sqlConnection);
                    SqlDataReader dataReader = fetchCommand.ExecuteReader();
                    Console.WriteLine($"No. of columns: {dataReader.FieldCount}");
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"emp_id: {dataReader.GetValue(0)}, " +
                            $"emp_name: {dataReader.GetValue(1)}," +
                            $"emp_phone: {dataReader.GetValue(2)}," +
                            $"emp_dob: {dataReader.GetValue(3)}");
                    }
                }
                else
                    Console.WriteLine("SqlConnection is null!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("------------ Exception block -------------");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        internal void Update()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = SingletonDP_DatabaseConnection.GetConnection();
                if (sqlConnection != null)
                {
                    Console.WriteLine("Enter Employee id to update: ");
                    int id = int.Parse(Console.ReadLine());

                    string fetchQuery = "select * from Employees where emp_id = " + id;
                    SqlCommand fetchCommand = new SqlCommand(fetchQuery, sqlConnection);
                    SqlDataReader sqlDataReader = fetchCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Close();
                        Console.WriteLine("Enter Employee name to upadte: ");
                        string name = Console.ReadLine();
                        string updateQuery = "update Employees set emp_name = '" + name + "'";
                        SqlCommand updatecommand = new SqlCommand(updateQuery, sqlConnection);
                        updatecommand.ExecuteNonQuery();
                        Console.WriteLine("Employee data updated successfully!!!");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found for id: " + id);
                        return;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("------------ Exception block -------------");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        internal void Delete()
        {
            SqlConnection sqlConnection = null;
            try
            {
                sqlConnection = SingletonDP_DatabaseConnection.GetConnection();
                if (sqlConnection != null)
                {
                    Console.WriteLine("Enter Employee id to delete: ");
                    int id = int.Parse(Console.ReadLine());
                    string fetchQuery = "select * from Employees where emp_id = " + id;
                    SqlCommand fetchCommand = new SqlCommand(fetchQuery, sqlConnection);
                    SqlDataReader sqlDataReader = fetchCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        sqlDataReader.Close();
                        string deleteQuery = "delete from Employees where emp_id = " + id;
                        SqlCommand deleteCommnd = new SqlCommand(deleteQuery, sqlConnection);
                        deleteCommnd.ExecuteNonQuery();
                        Console.WriteLine("Employee data deleted successfully");
                    }
                    else
                    {
                        Console.WriteLine("Employee not found for id: " + id);
                        return;
                    }

                }
                else
                    Console.WriteLine("SqlConnection is null!!!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("------------ Exception block -------------");
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
        }

        internal void DB_CRUD_Operations()
        {
            Console.WriteLine("Select the below options: ");
            Console.WriteLine("1.Create\n2.Retrieve\n3.Update\n4.Delete\n5.Exit");
            int choice = 0;
            do
            {
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    //case 1: 

                }

            } while (choice == 5);
        }
    }
}
