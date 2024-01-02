using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PITSurvey.Models
{
    public class Sections11_13
    {
        [Key, ForeignKey("SurveyAnswers")]
        public int SurveyResponseID { get; set; } //checked
        public string IllnessOrMedicalCondition { get; set; } // checked
        public string PhysicalLimitation { get; set; } // checked
        public string LearningOrCognitiveLimitations { get; set; } // checked
        public string MentalHealthIssue { get; set; } // checked
        public string SubstanceUseIssue { get; set; } // checked
        public string BrainInjuryAfterBirth { get; set; } // checked
        public string Gender { get; set; }
        public string SexualOrientation { get; set; }


        public virtual SurveyAnswers SurveyAnswers { get; set; }
    }
}
