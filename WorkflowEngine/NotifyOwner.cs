using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class NotifyOwner : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email to notify the owner about the encoding process launch");
        }
    }
}
