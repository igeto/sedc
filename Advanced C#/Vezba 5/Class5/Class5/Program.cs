using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] countries = { "India", "USA", "Pakistan" };
            int CLength = countries.Min(x => x.Length);
            int CSum = countries.Sum(x => x.Length);
            double CLengthAverage = countries.Average(x => x.Length);
            string result = countries.Aggregate((a, b) => a + a.Length + b.Length);
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            List<int> OddList = (List<int>)myList.Where(x => x % 2 != 0);
            int suma = myList.Where(x => x % 2 != 0).Sum();
            List<Student> myStudents = new List<Student>();
            var studentIds = myStudents.Select(x => x.ID);
            var StudentNames = myStudents.Select(x => new { Name = x.FirstName + " " + x.LastName, IdSquared = x.ID * x.ID });
            Console.WriteLine(studentIds);
            Console.ReadLine();
        }
        class Student
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
}
