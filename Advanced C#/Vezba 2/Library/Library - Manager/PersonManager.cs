using Library.Models;
using MyExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library___Manager
{
    public class PersonManager
    {
        List<Person> persons = new List<Person>();

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        public void RemovePerson(Person personToRemove)
        {
            if (persons.Any(person => person == personToRemove))
                foreach (var person in persons)
                {
                    if (person.Id == personToRemove.Id)
                    {
                        persons.Remove(person);
                    }
                }
            else
            {

            }
        }
        internal Person GetPersonByFullName(string firstName, string lastName)
        {
            try
            {
                foreach (var person in persons)
                {

                    if (person.FirstName == firstName && person.LastName == lastName)
                    {
                        return person;
                    }
                }
                throw new UserNotFoundException("Person not found");
            }
            
            catch (UserNotFoundException ex)
            {
                //log that a person is not found!
                return null;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
