using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    class OracleConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Oracle connection is open"); 

        }
        
        public override void Close()
        {
            Console.WriteLine("Oracle connection is closed"); 
        }

        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            this.Timeout = new TimeSpan(0, 0, 5);
        }
    }
}
