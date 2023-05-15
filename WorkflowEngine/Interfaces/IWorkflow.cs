using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void AddActivity( IActivity activity);
        void RemoveActivity(IActivity activity);

        IEnumerable<IActivity> GetActivities();
    }
}
