using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
	public class Workflow : IWorkflow
	{
		private readonly List<IActivity> _activities;

		private Workflow()
		{
			_activities = new List<IActivity>();
		}

		public IEnumerable<IActivity> Activities => _activities;

		public static IWorkflow StartWith(IActivity activity)
		{
			return new Workflow().Add(activity);
		}

		public IWorkflow Add(IActivity activity)
		{
			_activities.Add(activity);
			return this;
		}

		public void Run()
		{
            WorkflowEngine.Run(this);
		}
	}
}
