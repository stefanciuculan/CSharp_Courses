using System;

namespace StackOverflow_Post
{
    public class Post
    {

        public int VoteValue { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateAndTime { get; set; }

        public void Vote(string vote)
        {
            if (vote == "up")
                this.VoteValue++;
            else
            {
                if (vote == "down")
                    this.VoteValue--;
                else
                    throw new InvalidOperationException("You should vote 'up' or 'down'");
            }
            Console.WriteLine("Your post vote value is " + this.VoteValue);
        }
           
    }
}
