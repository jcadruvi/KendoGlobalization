using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGlobal.Models;
using KendoGlobal.Services;
using System.Globalization;
using System.Threading;

namespace KendoGlobal.Controllers
{
    public class HomeController : Controller
    {
        private ICultureService _cultureService;
        public HomeController(ICultureService cultureService)
        {
            _cultureService = cultureService;
        }
        //
        // GET: /Home/

        public ActionResult Index()
        {
            JobViewModel model = new JobViewModel();
            return View("Index", model);
        }

        [HttpPost]
        public JsonResult Post(JobViewModel job)
        {
            return null;
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            CultureInfo cultureInfo = new CultureInfo(_cultureService.GetCurrentCulture());
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo; 
            base.OnActionExecuting(filterContext);
        }
    }
}
