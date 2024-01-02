using System.ComponentModel.DataAnnotations;

namespace PITSurvey.Models
{
    public class SurveyAnswers
    {
        [Key]
        public int SurveyResponseID { get; set; }
        public string SurveyorInitials { get; set; } // not in page
        public string ContactNumber { get; set; } // not in page
        [Required(ErrorMessage = "Please enter your age.")]
        public string SurveyorAge { get; set; } // checked
        public int SurveyorYearBirth { get; set; } // checked

        public virtual Sections3_5 Sections3_5 { get; set; }
        public virtual Sections6_10 Sections6_10 { get; set; }
        public virtual Sections11_13 Sections11_13 { get; set; }
        public virtual Section14 Section14 { get; set; }
        public virtual Sections15_19 Sections15_19 { get; set; }
        public virtual ICollection<FamilyMembers> FamilyMembers { get; set; }

    }

}
