using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>()
            {
                new Person() {Id = 1, FirstName = "Igor", LastName = "Mitkovski", Birthday = new DateTime(1988, 2, 19), Gender = Gender.Male},
                new Person() {Id = 2, FirstName = "Martin", LastName = "Mitkovski", Birthday = new DateTime(2001, 3, 12), Gender = Gender.Male},
                new Person() {Id = 3, FirstName = "Filip", LastName = "Vancevski", Birthday = new DateTime(1990, 10, 14), Gender = Gender.Male},
                new Person() {Id = 4, FirstName = "Nadica", LastName = "Zogravska", Birthday = new DateTime(1988, 2, 19), Gender = Gender.Female},
                new Person() {Id = 5, FirstName = "Katerina", LastName = "Veloska", Birthday = new DateTime(1992, 5, 21), Gender = Gender.Female}
            };
            var personIgor = persons.Where(person => person.FirstName == "Igor").FirstOrDefault();
            var filteredPersons = persons.Where(person => person.LastName == "Mitkovski").ToList();
            var filteredPeople = persons.Where(person => DateTime.Now.Year - person.Birthday.Year >= 18).ToList(); ;
            var malePersons = persons.Where(person => person.Gender == Gender.Male).OrderByDescending(person => person.FirstName).ToList();

            Console.WriteLine("Male ordered persons");
            PrintPersons(malePersons);

            Console.WriteLine("18 and over");
            PrintPersons(filteredPeople);

            persons.ForEach(person => person.Birthday = person.Birthday.AddYears(10));
            PrintPersons(persons);

            Console.ReadLine();
        }
        static void PrintPersons(List<Person> persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine(string.Format("ID: {0}, First Name: {1}, Last Name: {2}, Birthday: {3}, Gender: {4}", 
                    person.Id, person.FirstName, person.LastName, person.Birthday, person.Gender));
            }
        }
       
    }
}
