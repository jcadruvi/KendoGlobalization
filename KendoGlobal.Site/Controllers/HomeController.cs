using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoGlobal.Models;
using KendoGlobal.Services;

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
            model.Culture = _cultureService.GetCurrentCulture();
            return View("Index", model);
        }

    }
}
