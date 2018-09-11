using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSamurai.Data
{
    public class SamuraiRepo
    {

        private SamuraiContext _context;

        public SamuraiRepo(SamuraiContext context)
        {
            _context = context;
        }

        public string GetFirstSamuraiName()
        {
            return _context.Samurais.FirstOrDefault().Name;
        }

    }
}
