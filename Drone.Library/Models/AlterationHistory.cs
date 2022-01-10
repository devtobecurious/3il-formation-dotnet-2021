using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Library.Models
{
    /// <summary>
    /// History of drone alteration
    /// </summary>
    public class AlterationHistory
    {
        #region Constructors
        public AlterationHistory(Drone drone, DateTime date, AlterationReason reason)
        {
            this.Drone = drone;
            this.Date = date;   
            this.Reason = reason;
        }
        #endregion

        #region Properties
        public Drone Drone { get; init; }
        public DateTime Date { get; init; }
        public AlterationReason Reason { get; init; }
        #endregion
    }
}
