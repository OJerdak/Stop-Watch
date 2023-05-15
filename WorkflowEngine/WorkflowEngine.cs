using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    public static class WorkflowEngine
    {

        public static void Run(IWorkflow workflow)
        {

            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }

        }
    }
}
