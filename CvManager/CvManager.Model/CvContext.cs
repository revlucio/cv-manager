using System.Data.Entity;

namespace CvManager.Model
{
    public class CvContext : DbContext
    {
        public DbSet<Cv> Cvs { get; set; } 
    }
}