using Reflection.Models;
using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Customer> customers = new List<Customer>()
            {
                new Customer(1, 12),
                new Customer(2, 21),
                new Customer(3, 23)
            };
            ////var customer = new Customer();
            ////var fullName = customer.GetFullName("Igor", "Mitkovski");
            ////Console.WriteLine(fullName);

            //Assembly MyAssembly = Assembly.GetExecutingAssembly();
            //Type customerType = MyAssembly.GetType("Reflection.Models.Customer");

            ////Object customerInstance = Activator.CreateInstance(customerType);
            ////MethodInfo getFullName = customerType.GetMethod("GetFullName");
            ////string[] myParameters = new string[2];
            ////myParameters[0] = "Igor";
            ////myParameters[1] = "Mitkovski";
            ////string fullName = (string)getFullName.Invoke(customerInstance, myParameters);
            ////Console.WriteLine(fullName);

            ////display all of the methods of Customer
            //var methods = customerType.GetMethods();
            //Console.WriteLine(methods[0]);
            //foreach (var item in methods)
            //{
            //    Console.WriteLine(item);
            //}
            //display all of the properties of Customer
            var customerType = typeof(Customer);
            var properties = customerType.GetProperties();

            var header = properties.Select(x => x.Name).Aggregate((a, b) => a + " -- " + b);
            Console.WriteLine(header);

            foreach (var customer in customers)
            {
                string newCustomer = string.Empty;
                foreach (var property in properties)
                {
                    newCustomer += " -- " + property.GetValue(customer);
                }
                Console.WriteLine(newCustomer);
            }

            //display all of the Constructors of Customer
            var constructors = customerType.GetConstructors();

            foreach (var item in constructors)
            {
                Console.WriteLine(item);
            }



            Console.ReadLine();
        }
    }
}
