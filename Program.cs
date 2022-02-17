using System;

namespace StringReversal // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            Console.Write("Enter a string: ");
            value = Console.ReadLine();
            string reversed_value = new string(value.Reverse().ToArray());
            if (reversed_value == value)
            {
                Console.WriteLine("Looks like you\'ve got a palindrome!");
            }
            Console.WriteLine(reversed_value);
        }
    }
}