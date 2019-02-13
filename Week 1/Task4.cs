using System;

namespace Application
{
    class MainClass
    {
        public static void Main(string[] args)
        { 
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++) {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine("");
            }

        }
    }
}
