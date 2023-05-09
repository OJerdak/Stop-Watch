using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProject
{
    public class DbCommand
    {
        public string Instruction { get; set; }

        public DbConnection Connection { get; set; }

        public DbCommand(DbConnection connection, string instruction)
        {
            if(connection == null )
            {
                throw new InvalidOperationException("There's no active database connection");
            }
            else
            {
                this.Connection = connection;
            }

            if (String.IsNullOrWhiteSpace(instruction))
            {
                throw new InvalidOperationException("Invalid instruction");
            }
            else
            {
                this.Instruction = instruction;
            }

        }

        public void Execute()
        {
            this.Connection.Open();
            Console.WriteLine("Executing {0}", Instruction);
            this.Connection.Close();

        }

    }
}
