using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EndoriskProject.Models.Mapping
{
    public class endoanswerMap : EntityTypeConfiguration<endoanswer>
    {
        public endoanswerMap()
        {
            // Primary Key
            this.HasKey(t => new { t.idQuiz, t.idQuestion });

            // Properties
            this.Property(t => t.idQuiz)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.idQuestion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.answer)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("endoanswers", "endorisk");
            this.Property(t => t.idQuiz).HasColumnName("idQuiz");
            this.Property(t => t.idQuestion).HasColumnName("idQuestion");
            this.Property(t => t.answer).HasColumnName("answer");
        }
    }
}
