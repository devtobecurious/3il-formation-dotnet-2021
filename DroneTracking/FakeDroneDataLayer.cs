using Drone.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneTracking
{
    internal class FakeDroneDataLayer : IDroneDataLayer
    {
        #region Public methods
        public List<Drone.Library.Models.Drone> GetAll()
        {
            return new List<Drone.Library.Models.Drone>()
            {
                new Drone.Library.Models.Drone("12345"),
                new Drone.Library.Models.Drone("12346"),
                new Drone.Library.Models.Drone("12349"),
                new Drone.Library.Models.Drone("12352") { UseStatus = Drone.Library.Models.UseStatus.Using },
            };
        }
        #endregion
    }
}
