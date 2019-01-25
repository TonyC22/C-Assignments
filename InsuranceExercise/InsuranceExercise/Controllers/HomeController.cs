using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InsuranceExercise.ViewModels;
using InsuranceExercise.Models;

namespace InsuranceExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ProcessInsuranceBuyer(string firstName, string lastName, string emailAddress, DateTime dateOfBirth, DateTime carYear, string carMake, string carModel, bool? hasHadDUI, int? speedingTickets, bool? coverageVsLiability)
        {
            using (InsuranceEstimatesDBEntities db = new InsuranceEstimatesDBEntities())
            {
                var InsuranceBuyer = new InsuranceBuyer();
                InsuranceBuyer.FirstName = firstName;
                InsuranceBuyer.LastName = lastName;
                InsuranceBuyer.EmailAddress = emailAddress;
                InsuranceBuyer.DateOfBirth = dateOfBirth;
                InsuranceBuyer.CarYear = carYear;
                InsuranceBuyer.CarMake = carMake;
                InsuranceBuyer.CarModel = carModel;
                
                if (Request.Form["HasHadDUI"] == "Yes")
                {
                    InsuranceBuyer.HasHadDUI = true;
                }
                else
                {
                    InsuranceBuyer.HasHadDUI = false;
                }

                InsuranceBuyer.SpeedingTickets = speedingTickets;

                if (Request.Form["CoverageVsLiability"] == "Full Coverage")
                {
                    InsuranceBuyer.CoverageVsLiability = true;
                }
                else
                {
                    InsuranceBuyer.CoverageVsLiability = false;
                }
                db.InsuranceBuyers.Add(InsuranceBuyer);
                db.SaveChanges();
                var InsuranceBuyerProcessed = new InsuranceBuyerProcessed();
                var InsuranceBuyersProcessed = new List<InsuranceBuyerProcessed>();
                int finalQuote = 50;
                InsuranceEstimate.CalculateQuote(InsuranceBuyer, out finalQuote);
                InsuranceBuyerProcessed.FirstName = InsuranceBuyer.FirstName;
                InsuranceBuyerProcessed.LastName = InsuranceBuyer.LastName;
                InsuranceBuyerProcessed.EmailAddress = InsuranceBuyer.EmailAddress;
                InsuranceBuyerProcessed.DateOfBirth = InsuranceBuyer.DateOfBirth;
                InsuranceBuyerProcessed.CarYear = InsuranceBuyer.CarYear;
                InsuranceBuyerProcessed.CarMake = InsuranceBuyer.CarMake;
                InsuranceBuyerProcessed.CarModel = InsuranceBuyer.CarModel;
                InsuranceBuyerProcessed.HasHadDUI = InsuranceBuyer.HasHadDUI;
                InsuranceBuyerProcessed.SpeedingTickets = InsuranceBuyer.SpeedingTickets;
                InsuranceBuyerProcessed.CoverageVsLiability = InsuranceBuyer.CoverageVsLiability;
                InsuranceBuyerProcessed.FinalQuote = finalQuote;
                InsuranceBuyersProcessed.Add(InsuranceBuyerProcessed);
                return View("BuyerEstimate", InsuranceBuyersProcessed);
            }                  
        }
    }
}