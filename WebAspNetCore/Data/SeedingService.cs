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
            Department d2 = new Department(2, "Eletronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bobb@test.te", new DateTime(1994, 2, 5), 1000.0, d1);
            Seller s2 = new Seller(2, "Bob White", "bobw@test.te", new DateTime(1993, 2, 5), 1200.0, d2);
            Seller s3 = new Seller(3, "Bob Green", "bobg@test.te", new DateTime(1992, 2, 5), 1300.0, d3);
            Seller s4 = new Seller(4, "Bob Red", "bobr@test.te", new DateTime(1991, 2, 5), 1400.0, d4);
        }
    }
}
