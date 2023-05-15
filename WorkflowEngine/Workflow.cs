using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly IList<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _activities;
        }

        public void AddActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
        
        public void RemoveActivity(IActivity activity)
        {
            _activities.Add(activity);
        }
    }
}
