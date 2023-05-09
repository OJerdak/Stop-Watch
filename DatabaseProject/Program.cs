using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Exercise 1 --- DbConnection

                var sqlConnection = new SqlConnection("mysuperconnectionstring");

                sqlConnection.Open();

                sqlConnection.Close();

                var oracleConnection = new OracleConnection("mysuperconnectionstring");

                oracleConnection.Open();
                
                oracleConnection.Close();

                //Exercise 2 --- DbCommand

                var sqlDbCommand = new DbCommand(sqlConnection,"insert some values");

                sqlDbCommand.Execute();

                var oraclelDbCommand = new DbCommand(oracleConnection,"insert some values");

                oraclelDbCommand.Execute();

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            Console.ReadLine();
        }
    }
}
