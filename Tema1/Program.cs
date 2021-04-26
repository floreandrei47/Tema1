using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema1;

namespace Tema1
{
    class Program
    {
        static void Main(string[] args)
        {

            Factory autoFactory = new Factory();
            autoFactory.Name = "Fabrica Volkswagen";


            Car firstCar = new Car();
            firstCar.Model = "Golf";
            firstCar.Package = "Family";
            firstCar.Engine = "1.6 TFSI";
            autoFactory.cars.Add(firstCar);

            Car secondCar = new Car();
            secondCar.Model = "Seat";
            secondCar.Package = "Sport+";
            secondCar.Engine = "2.0 TDI";

            autoFactory.cars.Add(secondCar);



            Console.WriteLine($"Choose an option for {autoFactory.Name}: ");
            Console.WriteLine("\t1 - Show cars");
            Console.WriteLine("\t2 - Count Cars");
            Console.WriteLine("\t3 - Add new car");

            Console.Write("Please choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    autoFactory.ShowCar();
                    break;
                case "2":
                    Console.Clear();
                    autoFactory.CountCar();
                    break;
                case "3":
                    Console.Clear();

                    Console.WriteLine("Add the Model:");
                    string newModel = Console.ReadLine();

                    Console.WriteLine("Add the Package:");
                    string newPackage = Console.ReadLine();

                    Console.WriteLine("Add the Engine:");
                    string newEngine = Console.ReadLine();

                    autoFactory.AddCar(newModel, newPackage, newEngine);
                    Console.Clear();

                    Console.WriteLine($"The new car is: {newModel} {newPackage} {newEngine}");


                    break;

            }

        }


    }
}

