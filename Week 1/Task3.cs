using System;

namespace cs
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());

            string[] array = Console.ReadLine().Split();
            for (int i = 0; i < n; i++) {
                int j = Convert.ToInt32(array[i]);
            }

            for(int i = 0; i < n; i++) {
                Console.Write(array[i] + " " + array[i] + " ");
            }

        }
    }
}
