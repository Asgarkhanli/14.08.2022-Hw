using System;

namespace _14._08._2022_Hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task_01

            int total = 3;
            Person[] persons = new Person[total];

            for (int i = 0; i < total; i++)
            {
                persons[i] = new Person()
                {
                    Name = Console.ReadLine()
                };
            }

            for (int i = 0; i < total; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }
            Console.ReadLine();

        }
        public class Person
        {
            public string Name { get; set; }

            public override string ToString()
            {
                return "Hello! My name is " + Name;
            }
        }
    }
}
