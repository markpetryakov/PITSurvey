using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PITSurvey.Models
{
    public class FamilyMembers
    {
        [Key]
        public int FamilyMemberID { get; set; }
        public int SurveyResponseID { get; set; }
        public string Relationship { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        [ForeignKey("SurveyResponseID")]
        public virtual SurveyAnswers SurveyAnswers { get; set; }
    }
}
