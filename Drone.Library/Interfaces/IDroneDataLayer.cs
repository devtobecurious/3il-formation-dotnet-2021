using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drone.Library.Interfaces
{
    public  interface IDroneDataLayer
    {
        List<Models.Drone> GetAll();
    }
}
