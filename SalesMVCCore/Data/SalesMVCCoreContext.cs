using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMVCCore.Models;
using SalesMVCCore.Models.ViewModels;

namespace SalesMVCCore.Data
{
    public class SalesMVCCoreContext : DbContext
    {
        public SalesMVCCoreContext (DbContextOptions<SalesMVCCoreContext> options)
            : base(options)
        {
        }

        public DbSet<SalesMVCCore.Models.Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecords { get; set; }

    }
}
