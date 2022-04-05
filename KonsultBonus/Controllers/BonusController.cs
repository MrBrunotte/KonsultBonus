using KonsultBonus.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonsultBonus.Controllers
{
    public class BonusController : Controller
    {
        public ActionResult Index()
        {
            return View(new Bonus());
        }

        [HttpPost]
        public ActionResult Index(Bonus b)
        {
            if (b.NumberOfYearsInFirm > 5)
                b.Bonuspott = b.NettoResultat * 0.05;
            

            return View(b);
        }
        

    }
}
