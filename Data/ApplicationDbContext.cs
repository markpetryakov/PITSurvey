using Microsoft.EntityFrameworkCore;
using PITSurvey.Models;

namespace PITSurvey.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<SurveyAnswers> SurveyAnswers { get; set; }
    }
}
