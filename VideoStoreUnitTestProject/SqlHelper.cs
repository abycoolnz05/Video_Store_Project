using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Video_Store;
using System.Data.SqlClient;
using System.Data;


namespace VideoStoreUnitTestProject
{
    public class SqlHelper
    {
        private IDbConnection Connection { get; set; }
        public ConnectionState State => this.Connection.State;

        /// <summary>
        /// Create SqlHelper with connection string.
        /// </summary>
        /// <param name="connectionString">Connection String</param>
        public SqlHelper(string connectionString)
        {
            this.Connection = new SqlConnection(connectionString);
        }
        public void Open() => this.Connection.Open();
    }
}
