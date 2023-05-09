using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }

        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (!String.IsNullOrEmpty(connectionString))
            {
                this.ConnectionString = connectionString;
            }
            else
            {
                throw new InvalidOperationException("The connection string is empty");
            }

        }

        public abstract void Open();

        public abstract void Close();

    }
}
