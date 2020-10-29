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
            string word;
            string reverseWord;


            Console.WriteLine("Please enter your first name");
            first = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            last = Console.ReadLine();
            Console.WriteLine("Please enter your student number");
            number = Console.ReadLine();

            username = (last.Substring(0, 3) + first.Substring(0, 3) + number.Substring(number.Length - 3)).ToLower();
            email = (first[0] + last + "@parkside.ca").ToLower();


            Console.WriteLine($"Greetings {first}, your email is {email}, and your username is {username}");

            first = first.ToUpper();
            last = last.ToLower();

            reverseName = String.Concat(first, last);
            backwards = "";

            for (int i = reverseName.Length; i > 0; i --) 
            {
                backwards = string.Concat(backwards, reverseName[i-1]);
            }

            Console.WriteLine(backwards);
            Console.ReadLine();

            reverseWord = "";
            Console.WriteLine("Please enter a word");
            word = Console.ReadLine().ToLower();

            for (int i = word.Length; i > 0; i--)
            {
                reverseWord = string.Concat(reverseWord, word[i - 1]);
            }

            if (reverseWord.Equals(word))
            {
                Console.WriteLine("The word is a palindrome");
            }
            else
            {
                Console.WriteLine("The word is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
