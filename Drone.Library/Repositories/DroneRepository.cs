using Drone.Library.DataLayers;
using Drone.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Library.Repositories
{
    public class DroneRepository
    {
        #region Constructors
        public DroneRepository(IDroneDataLayer dataLayer)
        {
            this.Datalayer = dataLayer;
        }
        #endregion

        #region Public methods
        public List<Models.Drone> GetUsingAll()
        {
            // var list = (new DroneDataLayer()).GetAll(); // Code fortement couplé à l'instance (au new)

            var list = this.Datalayer.GetAll(); // Attention, ici, en vrai, on doit mettre un filtre à passer au datalayer

            var query = from drone in list
                        where drone.UseStatus == Models.UseStatus.Using
                        select drone;

            return query.ToList();
        }
        #endregion

        #region Properties
        public IDroneDataLayer Datalayer { get; init; }
        #endregion
    }
}
