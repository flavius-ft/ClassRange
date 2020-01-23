using System;

namespace ClassRange
{
    public class Program
    {
        internal static void Main()
        {
            string text = System.IO.File.ReadAllText(@"E:\JsonText.txt");

            Console.WriteLine(new Value().Match(text).Success() ? "Valid" : "Invalid");

            Console.Read();
        }
    }
}
