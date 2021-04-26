using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Factory
    {   
        public Factory()
        {
            cars = new List<Car>();
        }
        public string Name;
        public List<Car> cars;

        public void AddCar(string Model, string Package, string Engine)
        {
            Car item = new Car();
            item.Model = Model;
            item.Package = Package;
            item.Engine = Engine;
            cars.Add(item);
        }

        public void ShowCar()
        {

            foreach (var item in this.cars)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public void CountCar()
        {
            int i = 0;
            foreach (var item in this.cars)
            {
                i++;
            }
            Console.WriteLine(i);
        }


    }
}
