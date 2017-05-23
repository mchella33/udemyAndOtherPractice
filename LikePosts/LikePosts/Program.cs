using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikePosts
{
    class Program
    {
        static void Main(string[] args)
        {
            var friend = new List<string>();
            bool exitCondition = false;
            while (exitCondition==false)
            {
                Console.WriteLine("Enter a name or hit 'Enter' to exit.");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    exitCondition = true;
                else
                    friend.Add(input);
            }
            if (friend.Count == 1)
                Console.WriteLine(friend + " likes your post");
            else if (friend.Count == 2)
                Console.WriteLine(friend[0] + friend[1] + " like your post.");
            else if (friend.Count >= 3)
                Console.WriteLine(friend[0] + ", " + friend[1] + " and " + (friend.Count -2) + " other friends like your post");
            
            else
            Console.WriteLine(" ");
            Console.ReadLine();



        }
    }
}
