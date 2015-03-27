using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace EndoriskProject.Models.Mapping
{
    public class symptomMap : EntityTypeConfiguration<symptom>
    {
        public symptomMap()
        {
            // Primary Key
            this.HasKey(t => new { t.symptom1, t.abbr });

            // Properties
            this.Property(t => t.symptom1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.abbr)
                .IsRequired()
                .HasMaxLength(5);

            // Table & Column Mappings
            this.ToTable("symptoms", "endorisk");
            this.Property(t => t.symptom1).HasColumnName("symptom");
            this.Property(t => t.abbr).HasColumnName("abbr");
        }
    }
}
