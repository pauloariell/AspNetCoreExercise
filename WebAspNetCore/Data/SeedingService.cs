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

            Seller s1 = new Seller(1, "Bob Brown", "bobb@test.te", new DateTime(1994, 2, 1), 1000.0, d1);
            Seller s2 = new Seller(2, "Bob White", "bobw@test.te", new DateTime(1993, 2, 5), 1200.0, d2);
            Seller s3 = new Seller(3, "Bob Green", "bobg@test.te", new DateTime(1992, 2, 29), 1300.0, d3);
            Seller s4 = new Seller(4, "Bob Red", "bobr@test.te", new DateTime(1991, 2, 5), 1400.0, d4);
            Seller s5 = new Seller(5, "Bob Yellow", "boby@test.te", new DateTime(1999, 5, 8), 1700.0, d1);
            Seller s6 = new Seller(6, "Bob Purple", "bobp@test.te", new DateTime(1980, 12, 25), 2400.0, d3);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2018, 09, 12), 15000.0, Models.Enums.SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2018, 09, 05), 15000.0, Models.Enums.SaleStatus.Pending, s1);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2018, 09, 05), 15000.0, Models.Enums.SaleStatus.Canceled, s1);
            SalesRecord r4 = new SalesRecord(4, new DateTime(2018, 09, 06), 15000.0, Models.Enums.SaleStatus.Billed, s1);
            SalesRecord r5 = new SalesRecord(5, new DateTime(2018, 09, 07), 15000.0, Models.Enums.SaleStatus.Pending, s1);
            SalesRecord r6 = new SalesRecord(6, new DateTime(2018, 09, 08), 15000.0, Models.Enums.SaleStatus.Billed, s1);
            SalesRecord r7 = new SalesRecord(7, new DateTime(2018, 09, 09), 15000.0, Models.Enums.SaleStatus.Billed, s1);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7);

            _context.SaveChanges();
        }
    }
}
