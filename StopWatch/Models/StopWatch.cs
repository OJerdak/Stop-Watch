using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch.Models
{
    public class Timer
    {
        public DateTime StartTime { get; set; }
        public DateTime StopTime { get; set; }
        public bool isRunning { get; set; }
        public int Duration {
            get {
                var timeSpan = this.StopTime - this.StartTime;
                var duration = timeSpan.TotalSeconds;
                return Convert.ToInt32(duration);
            } 
        }

        public void Start()
        {
            this.StartTime = DateTime.Now;
        }
        public void Stop()
        {
            this.StopTime = DateTime.Now;
        }
    }
}
