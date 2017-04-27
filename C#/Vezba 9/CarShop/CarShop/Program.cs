using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>()
            {
                new Car() { Make = "BMW", Model = "320d", Year = 2005, Condition = ConditionEnum.New },
                new Car() { Make = "Opel", Model = "Vectra", Year = 1998, Condition = ConditionEnum.Crashed },
                new Car() { Make = "Mazda", Model = "RX-8", Year = 1998, Condition = ConditionEnum.Used },
                new Car() { Make = "Lada", Model = "Vesta", Year = 2015, Condition = ConditionEnum.New },
            };
            CheckCar(cars);
            Console.ReadLine();
        }
        static void CheckCar(List<Car> cars)
        {
            foreach (var car in cars)
            {
                switch (car.Condition)
                {
                    case ConditionEnum.Crashed:
                        Console.WriteLine("Don't buy this car, it is crashed");
                        break;
                    case ConditionEnum.Used:
                        Console.WriteLine("Check the status of this car before purchasing");
                        break;
                    case ConditionEnum.New:
                        Console.WriteLine("Buy this car man! Do it!");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
