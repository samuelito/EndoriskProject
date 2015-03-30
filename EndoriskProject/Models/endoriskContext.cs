using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using EndoriskProject.Models.Mapping;

namespace EndoriskProject.Models
{
    public partial class endoriskContext : DbContext
    {
        static endoriskContext()
        {
            Database.SetInitializer<endoriskContext>(null);
        }

        public endoriskContext()
            : base("Name=endoriskContext")
        {
        }

        public DbSet<administrator> administrators { get; set; }
        public DbSet<comment> comments { get; set; }
        public DbSet<disease> diseases { get; set; }
        public DbSet<endoanswer> endoanswers { get; set; }
        public DbSet<endochoice> endochoices { get; set; }
        public DbSet<endoquestion> endoquestions { get; set; }
        public DbSet<patient> patients { get; set; }
        public DbSet<patientsymptom> patientsymptoms { get; set; }
        public DbSet<romeanswer> romeanswers { get; set; }
        public DbSet<romechoice> romechoices { get; set; }
        public DbSet<romedependency> romedependencies { get; set; }
        public DbSet<romediagnosi> romediagnosis { get; set; }
        public DbSet<romequestion> romequestions { get; set; }
        public DbSet<romequestionnaire> romequestionnaires { get; set; }
        public DbSet<severity> severities { get; set; }
        public DbSet<symptom> symptoms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new administratorMap());
            modelBuilder.Configurations.Add(new commentMap());
            modelBuilder.Configurations.Add(new diseaseMap());
            modelBuilder.Configurations.Add(new endoanswerMap());
            modelBuilder.Configurations.Add(new endochoiceMap());
            modelBuilder.Configurations.Add(new endoquestionMap());
            modelBuilder.Configurations.Add(new patientMap());
            modelBuilder.Configurations.Add(new patientsymptomMap());
            modelBuilder.Configurations.Add(new romeanswerMap());
            modelBuilder.Configurations.Add(new romechoiceMap());
            modelBuilder.Configurations.Add(new romedependencyMap());
            modelBuilder.Configurations.Add(new romediagnosiMap());
            modelBuilder.Configurations.Add(new romequestionMap());
            modelBuilder.Configurations.Add(new romequestionnaireMap());
            modelBuilder.Configurations.Add(new severityMap());
            modelBuilder.Configurations.Add(new symptomMap());
        }
    }
}
