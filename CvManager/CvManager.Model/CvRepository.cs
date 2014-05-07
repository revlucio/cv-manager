using System.Linq;

namespace CvManager.Model
{
    public class CvRepository
    {
        private readonly CvContext _context;

        public CvRepository()
        {
            _context = new CvContext();
        }

        public Cv GetElizabethsCv()
        {
            return _context.Cvs.First();
        }

        public void CreateNewCv()
        {
            _context.Cvs.Add(new Cv());
            _context.SaveChanges();
        }
    }
}