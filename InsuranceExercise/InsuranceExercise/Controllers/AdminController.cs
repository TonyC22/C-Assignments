using InsuranceExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceExercise.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEstimatesDBEntities db = new InsuranceEstimatesDBEntities())
            {
                var InsuranceBuyers = db.InsuranceBuyers;
                var InsuranceBuyerVms = new List<InsuranceBuyersVm>();
                foreach (var InsuranceBuyer in InsuranceBuyers)
                {
                    var InsuranceBuyerVm = new InsuranceBuyersVm();
                    InsuranceBuyerVm.FirstName = InsuranceBuyer.FirstName;
                    InsuranceBuyerVm.LastName = InsuranceBuyer.LastName;
                    InsuranceBuyerVm.EmailAddress = InsuranceBuyer.EmailAddress;
                    InsuranceBuyerVms.Add(InsuranceBuyerVm);
                }

                return View(InsuranceBuyerVms);
            }
        }
    }
}