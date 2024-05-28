using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Car: Vehicle
    {
        public Driver SecondaryDriver { get; private set; }
       
        public Car(string name, int horsepower, int topSpeed, double acceleration, Driver mainDriver, Driver secondaryDriver):base(name,horsepower, topSpeed, acceleration,mainDriver)
        {
            SecondaryDriver = secondaryDriver;
        }

        public override void Participate()
        {
            IsPraticipating = !IsPraticipating;
        }
        public override void IncraseHorsepower(int horsepower)
        {
            Horsepower = Horsepower + horsepower;
        }
        public override void IncraseAcceleration(double precentage)
        {
            TopSpeed = TopSpeed - 15;
            Acceleration = Acceleration * (1 + precentage);
        }

        public override void IncraseTopSpeed(int speed)
        {
            TopSpeed = TopSpeed + speed;
            Acceleration = Acceleration * 0.90;
        }
        public override string ToString()
        {
            return $"Driver: {Driver.FirstName} {Driver.LastName}, SecondaryDriver: {SecondaryDriver.FirstName} {SecondaryDriver.LastName} CarName: {this.Name} TopSpeed: {this.TopSpeed} Acceleration: {this.Acceleration} Horsepower: {this.Horsepower}";   
        }


    }
}
