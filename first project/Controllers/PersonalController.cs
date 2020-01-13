using first_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstProjectDataLibrary;
using FirstProjectDataLibrary.BusinessLogic;

namespace first_project.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            var model = new UserCreationModel();
            model.SexTypes = UserProcessor.LoadSexTypes();

            return View(model);
        }

        public ActionResult ViewUsers()
        {
            var data = UserProcessor.LoadUsers();
            var sexTypes = UserProcessor.LoadSexTypes();
            var users = data.Select(row => new User
            {
                Name = row.Name,
                LastName = row.LastName,
                Email = row.Email,
                Description = row.Description,
                Age = row.Age,
                Id = row.Id,
                SexId = row.SexId,
                SexType = sexTypes.FirstOrDefault(x => x.Id == row.SexId).SexType
            }).ToList();

            return View(users);
        }

        [HttpPost]
        
        public ActionResult Result(UserCreationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

             UserProcessor.CreateUser(model.Name,
                    model.LastName,
                    model.Email,
                    model.Description,
                    model.Age,
                    model.SexId
                    );
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            UserProcessor.DeleteUser(id);

            return RedirectToAction("ViewUsers");
        }
    }
}