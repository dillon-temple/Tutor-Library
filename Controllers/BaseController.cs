
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LandR.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            ViewBag.Logged = HttpContext.Session.GetInt32("Logged");
            base.OnActionExecuting(filterContext);
        }
    }
}
