using Drone.Library.DataLayers;
using Drone.Library.Interfaces;
using Drone.Library.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace TrackDrone.Web.Controllers
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

    public class DroneController : Controller
    {
        #region Public methods
        public IActionResult Index()
        {
            // IDroneDataLayer datalayer = new DroneDataLayer();
            IDroneDataLayer datalayer = new FakeDroneDataLayer();
            DroneRepository repository = new(datalayer);

            var list = repository.GetUsingAll();

            return View(list);
        }
        #endregion
    }
}
