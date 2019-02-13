using System;

namespace pp2
{
    class MainClass
    {
        public static bool Prime(int n) {
            if (n == 0 || n == 1) return false;
            for(int i = 2; i <= Math.Sqrt(n); i++) {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = Console.ReadLine().Split();
            int Count = 0;
            string output = "";
            
            for(int i = 0; i < n; i++) {
                int j = Convert.ToInt32(array[i]);
                if (Prime(j))
                {
                    Count++;
                    output += array[i] + " ";
                }
            }

            Console.WriteLine(Count);
            Console.WriteLine(output);
        }

    }
}
