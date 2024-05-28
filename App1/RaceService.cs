using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    public class RaceService
    {
       public IList<IVehicle> FilterParticipatingVehicles(IList<IVehicle> vehicles)
        {
            IList<IVehicle> participatingVehicles = new List<IVehicle>();
            foreach (IVehicle vehicle in vehicles)
            {
                if (vehicle.IsPraticipating)
                    participatingVehicles.Add(vehicle);
            }
            return participatingVehicles;
        }
    }
}
