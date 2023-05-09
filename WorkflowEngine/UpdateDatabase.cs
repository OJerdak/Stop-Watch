using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class UpdateDatabase : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Changing video status to 'processing' in the database");
        }
    }
}
