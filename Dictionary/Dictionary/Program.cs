using System;

namespace _Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> students = new MyDictionary<int, string>();

            students.Add(1, "Büşra");
            Console.WriteLine("Total number of students: "+students.Count);
            students.Add(2, "Ahmet");
            students.Add(3, "Burcu");
            Console.WriteLine("Total number of students: "+students.Count);
        }
    }
}
