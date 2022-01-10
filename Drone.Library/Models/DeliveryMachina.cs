using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Library.Models
{
    /// <summary>
    /// All machina in the application
    /// Now, with just registration number
    /// </summary>
    public abstract class DeliveryMachina
    {
        #region Constructors
        public DeliveryMachina(string registrationNumber)
        {
            this.RegistrationNumber = registrationNumber;   
        }
        #endregion

        #region Properties
        public string RegistrationNumber { get; init; } = string.Empty;
        // public string RegistrationNumber { get; private set; } = string.Empty;
        #endregion
    }
}
