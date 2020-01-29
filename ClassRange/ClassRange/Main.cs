using System;

namespace ClassRange
{
    public class Program
    {
        internal static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(args[0]);

            Console.WriteLine(new Value().Match(text).Success() ? "Valid" : "Invalid");

            Console.Read();
        }
    }
}
