using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class Formula:Vehicle
    {
        public Formula(string name, int horsepower, int topSpeed, double acceleration, Driver driver):base(name,horsepower,topSpeed,acceleration,driver)
        {}

        public override void Participate()
        {
            IsPraticipating = !IsPraticipating;
        }
        public override void IncraseHorsepower(int horsepower)
        {
            Horsepower = Horsepower + horsepower + 10;
        }
        public override void IncraseAcceleration(double precentage)
        {
            TopSpeed = TopSpeed +5;
            Acceleration = Acceleration * (1 + precentage);
        }

        public override void IncraseTopSpeed(int speed)
        {
            TopSpeed = TopSpeed + speed;
            Acceleration = Acceleration * 1.05;
        }
        public override string ToString()
        {
            return $"Driver: {Driver.FirstName} {Driver.LastName} FormulaName: {this.Name} TopSpeed: {this.TopSpeed} Acceleration: {this.Acceleration} Horsepower: {this.Horsepower}";
        }
    }
}
