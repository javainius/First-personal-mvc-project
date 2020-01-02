using first_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstProjectDataLibrary;
using FirstProjectDataLibrary.BuisnessLogic;

namespace first_project.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            var model = new User();
            return View(model);
        }

        public ActionResult ViewUsers()
        {
            ViewBag.Message = "Users List";

            var data = UserProcessor.LoadUsers();
            List<User> users = new List<User>();

            foreach (var row in data)
            {
                users.Add(new User
                {
                    Name = row.Name,
                    LastName = row.LastName,
                    Email = row.Email,
                    Description = row.Description,
                    Age = row.Age
                });
            }

            return View(users);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Result(User model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

             int recoredsCreated = UserProcessor.CreateUser(model.Name,
                    model.LastName,
                    model.Email,
                    model.Description,
                    model.Age);
            return View(model);
        }
    }
}