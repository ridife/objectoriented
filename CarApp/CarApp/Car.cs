using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApp
{
    public class Car: Vehicle
    {
        private Engine anEngine;
        private int maxSpeed;

        public Car(string model, string brand, int maxSpeed):base(model,brand)
            {
            this.brand = brand;
            this.model = model;
            this.maxSpeed = maxSpeed;
        }

        new public void Acceleration()
        {
            Console.WriteLine("Ngebut bro..");
        }

        public void DeAcceleration(bool isEmergencyBrake)
        {
            Console.WriteLine("Emergency Brake Applied");
            base.DeAcceleration();
        }


    }
}
