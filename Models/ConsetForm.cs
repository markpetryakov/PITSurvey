using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PITSurvey.Models
{
    public class ConsentForm
    {
        // Properties to store the user's answers
        public string SurveyAnswer { get; set; }
        public string AgreeToConsent { get; set; }
        public string StayingLocation { get; set; }

        public static List<SelectListItem> GetLocationOptions()
        {
            return new List<SelectListItem>
            {
                new SelectListItem { Value = "A", Text = "A. Decline to answer" },
                new SelectListItem { Value = "B", Text = "B. Own appartment/house" },
                new SelectListItem { Value = "C", Text = "C. Someone else's place" },
                new SelectListItem { Value = "D", Text = "D. Motel/Hotel (Selaf-Funded)" },
                new SelectListItem { Value = "E", Text = "E. Hospital" },
                new SelectListItem { Value = "F", Text = "F. Treatment Center" },
                new SelectListItem { Value = "G", Text = "G. Jail, Prison, Remand Centre" },
                new SelectListItem { Value = "H", Text = "H. Homeless Shelter (Emergency, Family or Domestic Violence Shelter)" },
                new SelectListItem { Value = "I", Text = "I. Motel/Hotel (Funded by City or Homeless Program)" },
                new SelectListItem { Value = "J", Text = "J. Transitional Shelter/Housing" },
                new SelectListItem { Value = "K", Text = "K. Unsheltered in a public space (e.g. street, park, bus shelter, forest or abandoned building)" },
                new SelectListItem { Value = "L", Text = "L. Encampment (e.g. group of tents, makeshift shelters or other long-term outdoor settlement)" },
                new SelectListItem { Value = "M", Text = "M. Vehicle (Car, VAN, RV, TRUCK, BOAT)" },
                new SelectListItem { Value = "N", Text = "N. Unsure: Indicate probable location" }
            };
        }

    }
}


