using System;
using System.IO;

namespace Task1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string text = File.ReadAllText("/Users/apple/Desktop/input.txt");
            char[] txet = text.ToCharArray();
            Array.Reverse(txet);
            string s = new string(txet);
            if (s == text)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
