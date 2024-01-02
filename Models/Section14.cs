using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PITSurvey.Models
{
    public class Section14
    {
        [Key, ForeignKey("SurveyAnswers")]
        public int SurveyResponseID { get; set; }
        public string HousingAndFinancialIssues { get; set; }
        public string InterpersonalAndFamilyIssues { get; set; }
        public string HealthOrCorrections { get; set; }
        public string OtherHousingLossReason { get; set; }
        public string CovidRelatedLoss { get; set; }
        public string HousingLossHappenedAgo { get; set; }

        


        public virtual SurveyAnswers SurveyAnswers { get; set; }
    }
}
