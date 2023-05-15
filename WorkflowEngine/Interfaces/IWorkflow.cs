using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
	public interface IWorkflow
	{
		IEnumerable<IActivity> Activities { get; }

        IWorkflow Add(IActivity activity);

        void Run();
	}
}
