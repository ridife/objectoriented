using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Vehicle
    {
        protected string model;
        protected string brand;

        public Vehicle(string model, string brand)
        {
            this.model = model;
            this.brand = brand;
        }
        
        public void Acceleration()
        {
            Console.WriteLine("Berjalan");
        }

        public void DeAcceleration()
        {
            Console.WriteLine("Berhenti");
        }
    }
}
