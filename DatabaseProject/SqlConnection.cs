using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class SqlConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Sql Connection is open");
        }

        public override void Close()
        {
            Console.WriteLine("Sql Connection is closed");
            this.Timeout = new TimeSpan(0, 0, 5);
        }
        public SqlConnection(string connectionString)
        : base(connectionString)
        {

        }
    }
}
