using CvManager.Business;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace CvManager.Model
{
    public class CvContext : DbContext
    {
        public CvContext()
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<CvContext>());

            if (!Cvs.Any())
            {
                var generator = new CvGenerator();
                Cvs.Add(generator.GetElizabethsCv());
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Cv> Cvs { get; set; } 
    }
}