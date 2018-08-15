using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Store;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace VideoStoreUnitTestProject
{
    [TestClass]
    public class VideoStoreTest
    {  
        
        [TestMethod]
            public void SqlHelper_Connection_Test()
            {
                //Arrange.
                var conn = new SqlHelper("Data Source=ABHIMONIKA\\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=true;");
            //Act.
            conn.Open();
                //Assert.
                Assert.IsTrue(conn.State == ConnectionState.Open);
            }

        [TestMethod]
        public void TestMethod2()
        {
            
                var conn = new SqlHelper("Data Source=ABHIMONIKA\\SQLEXPRESS;Initial Catalog=VideoRental;Integrated Security=true;");
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("SELECT FirstName, LastName, Address, Title, RentalCost, DateRented, DateRented FROM Customer t1 INNER JOIN RentedMovies t2 ON t1.CustId = t2.CustIdFK INNER JOIN Movies t3 ON t3.MovieID = t2.MovieIDFK");
                 Assert.IsFalse(sqlcmd == null);
        }
    }
}

