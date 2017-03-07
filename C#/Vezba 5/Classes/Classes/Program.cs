using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[6];
            Array.Reverse(array);
            //string carMake = "VW";  <---- public class Car
            //string carModel = "Golf";  <---- public class Car
            //int carYear = 2015;  <---- public class Car
            //string carColor = "Blue"; <---- public class Car
            //Car myCar = new Car();
            //myCar.Make = "VW";
            //myCar.Model = "Golf";
            //myCar.Year = 2015;
            //myCar.Color = "White";

            //Console.WriteLine(string.Format("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color));
            //Console.WriteLine("{0:C}", myCar.DetermineMarketValue());

            //Car myOtherCar = myCar;
            //myCar.Make = "asdasdsa";
            //Console.WriteLine(string.Format("{0} {1} {2} {3}", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color));
            //myCar.DoSomething();

            //Human me = new Human("Igor", "Mitkovski");
            ////me.FirstName = "Igor";
            ////me.Lastname = "Mitkovski";
            //me.Birthday = new DateTime(1988, 02, 19);

            //Console.WriteLine(string.Format("{0} {1} {2}", me.FirstName, me.Lastname, me.Birthday.ToShortDateString()));
            //me.GetFullName();

            Bike myBike = new Bike();

            Console.ReadLine();
        }
        static double DetermineMarketValue(Car car)
        {
            double marketValue;

            if (car.Year > 2000)
            {
                marketValue = 20000;
            } else
            {
                marketValue = 10000;
            }
            return marketValue;
        }
    }
    //public class Car
    //{
    //    public string Make { get; set; }
    //    public string Model { get; set; }
    //    public int Year { get; set; }
    //    public string Color { get; set; }

    //    public double DetermineMarketValue()
    //    {
    //        double marketValue;

    //        if (Year > 2000)
    //        {
    //            marketValue = 20000;
    //        } else
    //        {
    //            marketValue = 10000;
    //        }
    //        return marketValue;
    //    }
    //    private string MethodTest()
    //    {
    //        return "IMA EDNO DETE, PELISTER SE VIKA!!! I SEKOJ DEN NA VARDAR NA GRADSKI MU GO PIKA";
    //    }
    //    /// <summary>
    //    /// I am doing something, unlike you,
    //    /// you worthless piece of shit
    //    /// </summary>
    //    public void DoSomething()
    //    {
    //        Console.WriteLine(MethodTest());
    //    }
    //}
}
