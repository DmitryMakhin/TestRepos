using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMyOwnDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=my;Trusted_Connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                // Ваш код для вызова метода CustomTable()
                CustomTableProcedure customTable = new CustomTableProcedure();
                customTable.CustomTable();
                customTable.CustomTable1();
                customTable.TestErrors();
                connection.Close();
                Console.WriteLine(customTable.logger.GetErrorLog());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
