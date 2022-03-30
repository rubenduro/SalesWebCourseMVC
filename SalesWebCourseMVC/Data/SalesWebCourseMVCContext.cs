using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebCourseMVC.Models
{
    public class SalesWebCourseMVCContext : DbContext
    {
        public SalesWebCourseMVCContext (DbContextOptions<SalesWebCourseMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
