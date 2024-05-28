using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public interface IVehicle
    {
        string Name { get; set; }
        int Horsepower { get;}
        int TopSpeed { get; }
        double Acceleration { get; }
        bool IsPraticipating { get;}
        Driver Driver { get; }
        void Participate();
        void IncraseHorsepower(int horsepower);

        void IncraseAcceleration(double precentage);

        void IncraseTopSpeed(int speed);



    }
}
