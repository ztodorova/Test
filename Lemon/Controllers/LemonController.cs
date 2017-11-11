using Lemon.Models;
using Lemon.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lemon.Controllers
{
    public class LemonController : Controller
    {
        private readonly ILemonService lemonService;

        public LemonController(ILemonService lemonService)
        {
            this.lemonService = lemonService;
        }

        // GET: Lemon
        public ActionResult Index()
        {
            var model = new LemonViewModel()
            {
                Names = lemonService.GetNames()
            };

            return View(model);

    }
}
}