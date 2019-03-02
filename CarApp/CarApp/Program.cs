using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("BRZ", "Subaru");
            Car car = new Car("FT86", "Toyota", 240);
            car.Acceleration();
            car.DeAcceleration();
            car.DeAcceleration(true);
            Console.ReadKey();

        }
    }
}
