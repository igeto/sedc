using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EM.ConsoleApp.Program;

namespace EM.ConsoleApp
{
    //public delegate void MyPrintDelegate(string message);
    
    class Program
    {
        public delegate bool MyPromotionDelegate(Employee employee);
        static void Main(string[] args)
        {
            //MyPrintDelegate myDelegate = new MyPrintDelegate(PrintMessage);
            //myDelegate("test test");

            Console.WriteLine("Store");
            //To be promoted : Experience > 5
            List<Employee> StoreEmployees = new List<Employee>();
            StoreEmployees.Add(new Employee() { ID = 1, Name = "Igor", Salary = 800, Experience = 6 });
            StoreEmployees.Add(new Employee() { ID = 2, Name = "Martin", Salary = 400, Experience = 1 });
            StoreEmployees.Add(new Employee() { ID = 3, Name = "Filip", Salary = 200, Experience = 3 });
            StoreEmployees.Add(new Employee() { ID = 4, Name = "Dejan", Salary = 800, Experience = 1 });

            //MyPromotionDelegate storeDelegate = new MyPromotionDelegate(IsPromotableForStore);
            new Employee().PromoteEmployee(StoreEmployees, employee => employee.Experience > 5);

            Console.WriteLine("Factory");
            //To be promoted : Experience > 10
            List<Employee> FactoryEmployees = new List<Employee>();
            FactoryEmployees.Add(new Employee() { ID = 1, Name = "Igor", Salary = 800, Experience = 16 });
            FactoryEmployees.Add(new Employee() { ID = 2, Name = "Martin", Salary = 400, Experience = 11 });
            FactoryEmployees.Add(new Employee() { ID = 3, Name = "Filip", Salary = 200, Experience = 9 });
            FactoryEmployees.Add(new Employee() { ID = 4, Name = "Dejan", Salary = 800, Experience = 10 });

            //MyPromotionDelegate factoryDelegate = new MyPromotionDelegate(IsPromotableForFactory);
            new Employee().PromoteEmployee(FactoryEmployees, IsPromotableForFactory);

            string name = "filip 2";
            name.SwitchFromUpperToLower();
            StringHelper.SwitchFromUpperToLower(name);

            Console.ReadLine();            
        }

        public static bool IsPromotableForStore(Employee employee)
        {
            return employee.Experience > 5;
        }
        public static bool IsPromotableForFactory(Employee employee)
        {
            return employee.Experience > 10;
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Salary { get; set; }
            public int Experience { get; set; }

            public void PromoteEmployee(List<Employee> employees, MyPromotionDelegate isPromotional)
            {
                foreach (var employee in employees)
                {
                    if (isPromotional(employee))
                    {
                        Console.WriteLine($"{employee.Name} with {employee.Experience} years of experience is promoted");
                    }
                }
            }
        }
    }
}
