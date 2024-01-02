using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PITSurvey.Models
{
    public class Sections3_5
    {
        [Key, ForeignKey("SurveyAnswers")]
        public int SurveyResponseID { get; set; }
        [Required(ErrorMessage = "Please enter your age when you first experienced homelessness.")]
        [Range(0, 120, ErrorMessage = "Please enter a valid age.")]
        public string FirstTimeHomeless { get; set; } // checked
        public string TimeHomeless { get; set; } //checked
        public string StayedInShelter { get; set; } // checked
        public string NotStayedInShelterReason { get; set; } // checked, need multiple choise


        public virtual SurveyAnswers SurveyAnswers { get; set; }
    }
}
