using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Linq;
using zoo_backend_vs.Data;
using zoo_backend_vs.Models;

namespace zoo_backend_vs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacilityController : ControllerBase
    {
        private readonly ZooDBContext _db;

        public FacilityController(ZooDBContext db)
        {
            _db = db;
        }

        // GET: api/foodstand
        [HttpGet("foodstand")]
        public ActionResult<IEnumerable<ServiceSpot>> GetFoodstands()
           {
            List<ServiceSpot> objFoodstandList =
                _db.serviceSpot.Where(f => f.S_Item == "餐飲").ToList();
            return Ok(objFoodstandList);
        }

        [HttpGet("giftshop")]
        public ActionResult<IEnumerable<ServiceSpot>> GetGiftShops()
        {
            List<ServiceSpot> objGiftshopList =
                _db.serviceSpot.Where(f => f.S_Item == "商店").ToList();
            return Ok(objGiftshopList);
        }

        [HttpGet("guestservices")]
        public ActionResult<IEnumerable<ServiceSpot>> GetGuestServices()
        {
         
            List<ServiceSpot> objGuestServiceList =
                _db.serviceSpot.Where(f => new[] { "娃娃車／輪椅租用", "列車站", "車站" }.Contains(f.S_Item)).ToList();
            return Ok(objGuestServiceList);
        }

       
    }


    //public class FoodstandController1 : Controller
    //{
    //    private readonly ZooDBContext _db;
    //    public FoodstandController1(ZooDBContext db) 
    //    {
    //        _db = db;
    //    }


    //    public IActionResult Index()
    //    {
    //        List<Foodstand> objFoodstandList = _db.Foodstands.ToList();
    //        return View();
    //    }

    //    [HttpGet]
    //    [Route("Facility/Foodstand")]
    //    public ActionResult<IEnumerable<Foodstand>> GetFoodstand()
    //    {
    //        //var foodstands =_db.Foodstands.ToList();
    //        List<Foodstand> objFoodstandList = _db.Foodstands.ToList();
    //        return Ok(objFoodstandList);
    //    }
    //}
}
