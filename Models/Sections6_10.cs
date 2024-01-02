using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PITSurvey.Models
{
    public class Sections6_10
    {
        [Key, ForeignKey("SurveyAnswers")]
        public int SurveyResponseID { get; set; } //checked
        public string ImmigrationStatus { get; set; } // checked
        public string TimeInCanada { get; set; } // checked
        public string DateInCanada { get; set; } // checked
        public string CanadianCitizen { get; set; } // checked
        public string NonCitizenStatus { get; set; } // checked
        public string LengthOfTimeInOttawa { get; set; } //checked
        public string LivedBeforeOttawa { get; set; } //checked
        public string ReasonForComingToOttawa { get; set; } //checked
        public string IndigenousCommunity { get; set; } // checked
        public string RacialIdentity { get; set; } //checked
        public string ServedMilitary { get; set; } // checked
        public string FosterCare { get; set; } // checked
        public string HomelessAfterFosterCare { get; set; } // checked


        public virtual SurveyAnswers SurveyAnswers { get; set; }
    }
}
