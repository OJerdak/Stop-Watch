using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Workflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void Run(Activity activity)
        {
            foreach(var act in _activities)
            {
                act.Execute();
            }
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
