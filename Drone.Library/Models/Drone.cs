using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Library.Models
{
    /// <summary>
    /// Drone to be usefull in the application
    /// </summary>
    public class Drone : DeliveryMachina
    {
        #region Constructors
        public Drone(string registrationNumber) : base(registrationNumber)
        {
            
        }
        #endregion

        #region Properties
        public UseStatus UseStatus { get; set; } = UseStatus.Free;
        public List<AlterationHistory> AlterationHistories { get; set; } = new List<AlterationHistory>();
        #endregion
    }
}
