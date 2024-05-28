using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class CircuitRace:Race
    {

        public CircuitRace(IList<IVehicle> vehicles,RaceService raceService):base(vehicles,raceService)
        {
            
        }

        public override IVehicle StartRace()
        {
            IList<IVehicle> participatingVehicles = RaceService.FilterParticipatingVehicles(Vehicles);
            Random rnd = new Random();
            int random= rnd.Next(Vehicles.Count);
            return Vehicles[random];
        }
    }
}
