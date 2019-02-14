using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText("/Users/apple/Desktop/input.txt");
            char[] text2 = text.ToCharArray();
            Array.Reverse(text2);
            string s = new string(text2);
            if (s == text)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
