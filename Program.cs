using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_8_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string first;
            string last;
            string number;
            string username;
            string email;
            string reverseName;
            string backwards;


            Console.WriteLine("Please enter your first name");
            first = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            last = Console.ReadLine();
            Console.WriteLine("Please enter your student number");
            number = Console.ReadLine();

            username = (last.Substring(0, 3) + first.Substring(0, 3) + number.Substring(number.Length - 3)).ToLower();
            email = (first[0] + last + "@parkside.ca").ToLower();


            Console.WriteLine($"Greetings {first}, your email is {email}, and your username is {username}");

            first = first.ToLower();
            last = last.ToLower();

            reverseName = String.Concat(first, last);
            backwards = String.

            Console.ReadLine();



        }
    }
}
