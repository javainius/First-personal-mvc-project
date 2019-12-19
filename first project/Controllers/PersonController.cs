using first_project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace first_project.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            var person = new Person(); //{ Code = code("https://www.youtube.com/watch?v=l2pAuSRrG7c")};
            return View(person);
        }
        [HttpPost]
        public ActionResult Result(Person model)
        {
            model.Age = CalculateYourAge(Convert.ToDateTime(model.BirthDate));
            return View(model);
        }

        static string CalculateYourAge(DateTime Dob)
        {
            DateTime Now = DateTime.Now;
            int Years = new DateTime(DateTime.Now.Subtract(Dob).Ticks).Year - 1;
            DateTime PastYearDate = Dob.AddYears(Years);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == Now)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= Now)
                {
                    Months = i - 1;
                    break;
                }
            }
            return String.Format("Age: {0} Year(s)",
            Years);
        }

        public static string code(string Url)
        {
            string result;
            using (WebClient client = new WebClient())
            {
                result = client.DownloadString(Url);
            }

            return result;
        }
    }
}