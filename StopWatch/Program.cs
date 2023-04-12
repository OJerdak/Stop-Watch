using StopWatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my stopwatch project, you may exit anytime you wish by entering 'E'");

            var sw = Timer.Instance;

            var command = default(ConsoleKey);
            while (command != ConsoleKey.E)
            {
                command = Console.ReadKey(true).Key;
                try
                {
                    if (command == ConsoleKey.R)
                    {
                        AttemptRun(sw);
                    }
                    else if (command == ConsoleKey.S)
                    {
                        AttemptStop(sw);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid character");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void AttemptRun(Timer sw)
        {
            if (sw.IsRunning)
            {
                throw new InvalidOperationException("There's an existing instance of the timer already running");
            }

            sw.Start();
            Console.WriteLine("The timer is running press 'S' to stop it");
        }

        private static void AttemptStop(Timer sw)
        {
            if (!sw.IsRunning)
            {
                throw new InvalidOperationException("There's no existing instance of the timer already running");
            }

            sw.Stop();
            Console.WriteLine("Timer has stopped, total duration is : {0} seconds", sw.Duration);
        }
    }
}
