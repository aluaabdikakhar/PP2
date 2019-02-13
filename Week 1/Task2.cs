using System;

namespace cs
{
    class Student {
        private int id;
        private static int idIncrement = 0;
        private string name;
        private int year;
        public Student(string name, int year)
        {
            this.id    = idIncrement++;
            this.name = name;
            this.year = year;
        }

        public string GetName() {
            return this.name;
        }

        public int GetYear()
        {
            return this.year;
        }

        public int GetId()
        {
            return this.id;
        }

        public void IncrementYear(){
            year++;
        }



    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Student W = new Student("gfhfkj", 4);
            Student Q = new Student("gfhfk", 1);
            Console.WriteLine(W.GetName() + " " + W.GetId() + " " + W.GetYear());
            Console.WriteLine(Q.GetName() + " " + Q.GetId() + " " + Q.GetYear());


            Q.IncrementYear();

            Console.WriteLine(Q.GetName() + " " + Q.GetId() + " " + Q.GetYear());

           
        }
    }
}
