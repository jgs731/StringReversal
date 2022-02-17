using System;

namespace StringReversal // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value = "";
            string reversed_value = "";
            Console.Write("Enter a string here: ");
            value = Console.ReadLine();
            reversed_value = new string(value.Reverse().ToArray());
            Console.WriteLine(reversed_value);
        }
    }
}