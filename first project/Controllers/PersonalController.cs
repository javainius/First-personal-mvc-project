using first_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace first_project.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            var user = new User();
            return View(user);
        }

        public ActionResult InvalidInput(User user)
        {
            
            return View("Index", user);
        }

        [HttpPost]
        public ActionResult Result(User model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("InvalidInput", model);
            }

            return View(model);
        }
    }
}