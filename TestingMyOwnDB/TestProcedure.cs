using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingMyOwnDB
{
    [TestClass]
    public class TestProcedure
    {
        [TestMethod]
        public void TestCustomTable()
        {
            string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=my;Trusted_Connection=true";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Test running now ...");
                new CustomTableProcedure().CustomTable();
                Console.WriteLine("Test finished ...");
                connection.Close();
            }
        }
        [TestMethod]
        public void TestSome()
        {
            Assert.IsTrue(2 + 2 == 4);
        }
    }
}
