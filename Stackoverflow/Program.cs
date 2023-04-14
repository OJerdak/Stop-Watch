using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackoverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = default(ConsoleKey);

            Console.Title = "Stackoverflow";

            Console.WriteLine("Welcome to {0}", Console.Title);

            Console.WriteLine("\nEnter The Following to create a new post");
            var post = new Post();

            Console.WriteLine("\nThe issue you are facing : ");
            post.Title = Console.ReadLine();

            Console.WriteLine("A brief description about the issue : ");
            post.Description = Console.ReadLine();

            Console.WriteLine("\nNow choose wether you want to up-vote or down-vote your post");

            Console.WriteLine("\tFor up-voting press 'U'");

            Console.WriteLine("\tFor down-voting press 'D'");

            Console.WriteLine("\n Enter 'S' to stop the voting.");

            while (command != ConsoleKey.S)
            {
                command = Console.ReadKey(true).Key;

                switch (command)
                {
                    case ConsoleKey.U:
                        post.UpVote();
                        break;
                    case ConsoleKey.D:
                        post.DownVote();
                        break;
                }


            }

            Console.WriteLine("\n Post : ");

            Console.WriteLine("\n\t Issue : {0}", post.Title);
            Console.WriteLine("\n\t Description : {0}", post.Description);
            Console.WriteLine("\n\t Created On : {0}", post.CreatedOn.ToString("dd,MM,yyyy"));
            Console.WriteLine("\n\t Voting Rank : {0}", post.VoteRank);

            Console.ReadKey();


        }
    }
}
