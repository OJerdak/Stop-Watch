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
            BuildAndRunWorkflow();
			Console.ReadLine();
		}

		public static void BuildAndRunWorkflow()
		{
            Workflow.StartWith(new UploadVideo())
                .Add(new NotifyEncoder())
                .Add(new NotifyOwner())
                .Add(new UpdateDatabase())
                .Run();
		}
	}
}
