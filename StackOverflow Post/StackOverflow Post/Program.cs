using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post();
            string input;

            CreatePost(post);

            while(true)
            {
                input = Console.ReadLine();

                if (input == "close")
                {
                    Console.WriteLine("Your post vote value is " + post.VoteValue);
                    return;
                }

                else
                    post.Vote(input);
            }
        }

        static void CreatePost(Post post)
        {
            Console.WriteLine("Enter a new post title.");
            post.Title = Console.ReadLine();

            Console.WriteLine("Type a new description for your post.");
            post.Description = Console.ReadLine();

            post.VoteValue = 0;

            post.DateAndTime = DateTime.Now;
            Console.WriteLine("Your post creation date: " + post.DateAndTime);
        }
    }
}
