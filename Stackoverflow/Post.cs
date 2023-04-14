using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackoverflow
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; private set; }
        public int VoteRank { get; private set; }

        public Post()
        {
            VoteRank = 0;
            CreatedOn = DateTime.Now;
        }

        public void UpVote()
        {
            VoteRank += 1;
            Console.WriteLine("Current vote rank : {0}", VoteRank);

        }

        public void DownVote()
        {
            VoteRank -= 1;
            Console.WriteLine("Current vote rank : {0}", VoteRank);
        }

    }
}
