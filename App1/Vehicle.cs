using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public abstract class Vehicle:IVehicle
    {
        public string Name { get; set; }
        public int Horsepower { get; protected set; }
        public int TopSpeed { get; protected set; }
        public double Acceleration { get; protected set; }
        public bool IsPraticipating { get; protected set; }
        public Driver Driver { get; protected set; }
        protected Vehicle(string name, int horsepower, int topSpeed, double acceleration,Driver driver)
        {
            Name = name;
            Horsepower = horsepower;
            TopSpeed = topSpeed;
            Acceleration = acceleration;
            IsPraticipating = true;
            Driver = driver;
        }

        public abstract void Participate();
        public abstract void IncraseHorsepower(int horsepower);

        public abstract void IncraseAcceleration(double precentage);

        public abstract void IncraseTopSpeed(int speed);
    }
}
