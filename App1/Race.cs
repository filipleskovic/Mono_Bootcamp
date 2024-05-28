using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public abstract class Race
    {
        public RaceService RaceService { get; set; }
        public IList<IVehicle> Vehicles { get; private set; }

        protected Race(IList<IVehicle> vehicles,RaceService raceService)
        {
            Vehicles = vehicles;
            RaceService = raceService;
        }
        public abstract IVehicle StartRace();
        public void AddNewVeichle(IVehicle vehicle)
        {
            Vehicles.Append(vehicle);
        }
    }
}
