using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public  class SprintRace:Race
    {
        public SprintRace(IList<IVehicle> vehicles,RaceService raceService):base(vehicles,raceService) { }
        public override IVehicle StartRace()
        {
            IList<IVehicle> filteredVehicles = RaceService.FilterParticipatingVehicles(Vehicles);
            IVehicle firstvehicle= filteredVehicles.First();
            foreach(IVehicle vehicle in filteredVehicles)
            {
                if (vehicle.TopSpeed - vehicle.Acceleration * 30 > firstvehicle.TopSpeed - firstvehicle.Acceleration * 30)
                    firstvehicle = vehicle;
            }
            return firstvehicle;
        }
    }
}
