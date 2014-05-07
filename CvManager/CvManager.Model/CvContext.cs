using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CvManager.Model
{
    public class CvContext : DbContext
    {
        public CvContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CvContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Cv> Cvs { get; set; } 
    }
}