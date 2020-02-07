using CheckBox.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckBox.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            string[] values= {"not good", "good", "very good"};
            List<string> Liste = new List<string>(values);
           
            return View(Liste);
        }
        
        
        public ActionResult Show()
        {
            return View(this.Request.Form);
            
        }
     

    }
}