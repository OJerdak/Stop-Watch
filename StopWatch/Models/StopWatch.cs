using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch.Models
{
    public class Timer
    {
        public static Timer Instance = new Timer();

        private Timer()
        {
            Console.WriteLine("Enter 'R' to run the stopwatch and 'S' to stop it :");
        }

        private DateTime StartTime { get; set; }
        private DateTime StopTime { get; set; }
        public bool IsRunning { get; private set; }
        public string Duration {
            get {
                var timeSpan = this.StopTime - this.StartTime;
                return timeSpan.ToString("ss");
            }
        }

        public void Start()
        {
            this.StartTime = DateTime.Now;
            IsRunning = true;
        }
        public void Stop()
        {
            this.StopTime = DateTime.Now;
            IsRunning = false;
        }
    }
}
