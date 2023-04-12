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
        public static void Main()
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
                        sw.Start();
                        Console.WriteLine("The timer is running press 'S' to stop it");
                    }
                    else if (command == ConsoleKey.S)
                    {
                        var elapsedTime = sw.Stop();
                        Console.WriteLine("Timer has stopped, total duration is : {0} seconds", elapsedTime.ToString("ss"));
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
    }
}
