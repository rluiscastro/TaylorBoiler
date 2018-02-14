using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TaylorGPS.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TaylorGPSControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}