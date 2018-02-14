using System.Web.Mvc;

namespace TaylorGPS.Web.Controllers
{
    public class AboutController : TaylorGPSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}