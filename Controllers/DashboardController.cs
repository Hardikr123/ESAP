using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ESAP.Controllers
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string businessType { get; set; }

    }
    public class DashboardController : Controller
    {
        //
        // GET: /Dashboard/

        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// done with excel
        /// </summary>
        /// <returns></returns>
        public ActionResult ImportData()
        {
            //excel read here
            List<Customer> oCt = new List<Customer>()
            {
                new Customer(){businessType="SW",Email="111@yahoo.in",ID=1,Name="hdk1"},
                new Customer(){businessType="SW",Email="111@yahoo.in",ID=1,Name="hdk1"},
                new Customer(){businessType="HW",Email="111@yahoo.in",ID=1,Name="hdk1"},
                new Customer(){businessType="HW",Email="111@yahoo.in",ID=1,Name="hdk1"}
            };
            return Json(oCt,JsonRequestBehavior.AllowGet);
        }





    }
}
