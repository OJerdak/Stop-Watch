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

        public override string ToString()
        {
            return "\n Post : " +

            "\n\t Issue : " + Title +
            "\n\t Description : " + Description +
            "\n\t Created On : " + CreatedOn.ToString("dd,MM,yyyy") +
            "\n\t Voting Rank : " + VoteRank;
        }

        public void UpVote()
        {
            VoteRank += 1;
        }

        public void DownVote()
        {
            VoteRank -= 1;
        }

    }
}
