using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAspNetCore.Models;

namespace WebAspNetCore.Data
{
    public class SeedingService
    {
        private WebAspNetCoreContext _context;

        public SeedingService(WebAspNetCoreContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; // DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(1, "Eletronics");
            Department d3 = new Department(1, "Fashion");
            Department d4 = new Department(1, "Books");
        }
    }
}
