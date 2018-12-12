using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcRouter.Controllers
{
    public class ExampleRouterController : Controller
    {
        // GET: ExampleRouter
        public ActionResult select(int id,string name,string surname)
        {
            return Content("Your Id: "+id+"<br />"+"Your Name: "+name+"<br />"+"Your Surname: "+surname);
        }
    }
}