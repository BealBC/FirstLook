using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.FirstName = "Steve";
            m1.LastName = "Conger";
            m1.Email = "steve.conger@seattlecentral.edu";

            Mailing m2 = new Mailing();
            m2.FirstName = "Ben";
            m2.LastName = "Beal";
            m2.Email = "bbeal003@seattlecentral.edu";

            Mailing m3 = new Mailing();
            m3.FirstName = "John";
            m3.LastName = "Doe";
            m3.Email = "john.doe@seattlecentral.edu";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return View(mailings);
        }
    }
}