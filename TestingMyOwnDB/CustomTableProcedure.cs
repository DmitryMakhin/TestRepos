using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMyOwnDB
{
    public class CustomTableProcedure
    {
        public ExceptionLogger logger = new ExceptionLogger();
        public void CustomTable()
        {
            string exceptions = null;
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=my;Trusted_Connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECT table1.age," +
                        "     table2.address FROM table1JOIN table2 ON table1.id = table2.id", connection);
                    SqlDataReader reader = cmd.ExecuteReader(); 
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["age"]);
                        Console.WriteLine(reader["address"]);
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    logger.LogException(ex);
                }

            }
        }
        public void CustomTable1()
        {
            string exceptions = null;
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=my;Trusted_Connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("SELECTtable1.age," +
                        "     table2.address FROM table1 JOIN table2 ON table1.id = table2.id", connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine(reader["age"]);
                        Console.WriteLine(reader["address"]);
                    }
                    //throw new AccessViolationException();
                    //throw new ArgumentException();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    logger.LogException(ex);
                }

            }
        }
        public void TestErrors()
        {
            try
            {
                throw new Exception("1");
                throw new Exception("2");
                throw new Exception("4");
                throw new Exception("3");
                throw new Exception("9");
            }
            catch(Exception e)
            {
                logger.LogException(e);
            }
        }
    }
}
