using System;

namespace StopWatch
{
    public class StopWatch
    {
        public static StopWatch GetNewInstance => new StopWatch();

        private StopWatch() { }

        private DateTime? StartTime { get; set; }

        public bool IsRunning => StartTime != null;

        /// <summary>
        /// Starts the timer
        /// </summary>
        /// <exception cref="InvalidOperationException"></exception>
        public void Start()
        {
            if (IsRunning)
            {
                throw new InvalidOperationException("There's an existing instance of the timer already running");
            }

            StartTime = DateTime.Now;
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        /// <returns>The latest timer run's elapsed time</returns>
        /// <exception cref="InvalidOperationException"></exception>
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
