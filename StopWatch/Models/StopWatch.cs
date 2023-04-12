using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch.Models
{
    public class Timer
    {
        public static Timer Instance;

        static Timer()
        {
            Instance = Instance ?? new Timer();
        }

        private Timer()
        {
            Console.WriteLine("Enter 'R' to run the stopwatch and 'S' to stop it :");
        }

        private DateTime? StartTime { get; set; }

        public bool IsRunning => StartTime != null;

        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("There's an existing instance of the timer already running");
            }

            StartTime = DateTime.Now;
        }

        public TimeSpan Stop()
        {
            if (!IsRunning)
            {
                throw new InvalidOperationException("There's no existing instance of the timer already running");
            }

            var elapsed = DateTime.Now - StartTime.Value;
            StartTime = null;

            return elapsed;
        }
    }
}
