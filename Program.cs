using System;

namespace PalindromeCheckerUserinput
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindromchecker();
            while (true)
            {
                Palindromchecker();
            }
        }
        private static void Palindromchecker()
        {
            int rem, sum = 0, saved;
            Console.WriteLine("Please add a number: ");
            int palin = Convert.ToInt32(Console.ReadLine());
            saved = palin;
            while (palin > 0)
            {
                rem = palin % 10;
                palin = palin / 10;
                sum = sum * 10 + rem;
            }
            if (saved == sum)
            {
                Console.WriteLine("Its a palindrome!");
            }
            else
            {
                Console.WriteLine("Its not a palindrom!");
            }
        }
    }
}
