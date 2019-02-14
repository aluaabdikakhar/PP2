using System;
using System.IO;

namespace Task2
{
    class MainClass
    {
        static bool isPrime(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); ++i)
                if (x % i == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            string[] text = File.ReadAllText("/Users/apple/Desktop/input 2.txt").Split();
            using (StreamWriter file = new StreamWriter("/Users/apple/Desktop/output.txt"))
            {
                foreach (string number in text)
                {
                    int x = Convert.ToInt32(number);
                    if (isPrime(x))
                        file.Write(number + " ");
                }
            }
        }
    }
}
