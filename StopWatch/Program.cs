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
            Console.WriteLine("Enter 'R' to run the stopwatch and 'S' to stop it :");

            var sw = new Timer();

            string input = "";

            while (input != "E")
            {
                input = Console.ReadLine();

                try
                {
                    if (input == "R" && !sw.isRunning)
                    {
                        sw.Start();
                        sw.isRunning = true;
                        Console.WriteLine("The timer is running press 'S' to stop it");
                    }
                    else if (input == "R" && sw.isRunning)
                    {
                        throw new InvalidOperationException("There's an existing instance of the timer already running");
                    }
                    else if (input == "S" && sw.isRunning)
                    {
                        sw.Stop();
                        sw.isRunning = false;
                        Console.WriteLine("Timer has stopped, total duration is : {0} seconds", sw.Duration);
                    }
                    else if (input == "S" && !sw.isRunning)
                    {
                        sw.Stop();
                        throw new InvalidOperationException("There's no existing instance of the timer already running");
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid character");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);                    
                }

            }

        }
    }
}
