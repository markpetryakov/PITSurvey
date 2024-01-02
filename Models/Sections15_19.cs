using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PITSurvey.Models
{
    public class Sections15_19
    {
        [Key, ForeignKey("SurveyAnswers")]
        public int SurveyResponseID { get; set; }
        public string SourcesOfIncome { get; set; }
        public string LevelOfEducation { get; set; }
        public string WantToGetIntoPermanentHousing { get; set; }
        public string ChallengesToFindHousing { get; set; }
        public string SupportToHelpHousing { get; set; }



        public virtual SurveyAnswers SurveyAnswers { get; set; }
    }
}
