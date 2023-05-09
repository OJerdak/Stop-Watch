using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow = new Workflow();

            workflow.AddActivity(new UploadVideo());
            workflow.AddActivity(new NotifyEncoder());
            workflow.AddActivity(new NotifyOwner());
            workflow.AddActivity(new UpdateDatabase());

            workflow.Run(new Activity());

            Console.ReadLine();
        }
    }
}
