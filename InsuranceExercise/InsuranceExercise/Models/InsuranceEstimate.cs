using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceExercise.Models
{
    public class InsuranceEstimate
    {
        public int rateCost { get; set; }
        public int finalCost { get; set; }

        public static void CalculateQuote(InsuranceBuyer InsuranceBuyer, out int finalCost)
        {
            int rateCost = 50;

            if (DateTime.Now.Year - InsuranceBuyer.DateOfBirth.Value.Year < 25 && DateTime.Now.Year - InsuranceBuyer.DateOfBirth.Value.Year > 18
                && DateTime.Now.Year - InsuranceBuyer.DateOfBirth.Value.Year < 100)
            {
                rateCost += 25;
            }
            if (DateTime.Now.Year - InsuranceBuyer.DateOfBirth.Value.Year < 18)
            {
                rateCost += 100;
            }
            if (DateTime.Now.Year - InsuranceBuyer.DateOfBirth.Value.Year > 100)
            {
                rateCost += 25;
            }
            if (InsuranceBuyer.CarYear.Value.Year < 2000)
            {
                rateCost += 25;
            }
            if (InsuranceBuyer.CarYear.Value.Year > 2015)
            {
                rateCost += 25;
            }
            string lowerCarMake = InsuranceBuyer.CarMake.ToLower();
            string lowerCarModel = InsuranceBuyer.CarModel.ToLower();
            if (lowerCarMake == "porsche" && lowerCarModel != "911 carrera")
            {
                rateCost += 25;
            }
            if (lowerCarMake == "porsche" && lowerCarModel == "911 carrera")
            {
                rateCost += 50;
            }
            for (int i = 0; i < InsuranceBuyer.SpeedingTickets; i++)
            {
                if (i != InsuranceBuyer.SpeedingTickets)
                {
                    rateCost += 10;
                }
            }

            if (InsuranceBuyer.HasHadDUI == true)
            {
                rateCost += (rateCost / 4);
            }

            if (InsuranceBuyer.CoverageVsLiability == true)
            {
                rateCost += (rateCost / 2);
            }
            finalCost = rateCost;
        }
    }
}