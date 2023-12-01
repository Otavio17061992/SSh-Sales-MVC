using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesMVCCore.Models;

namespace SalesMVCCore.Data
{
    public class SalesMVCCoreContext : DbContext
    {
        public SalesMVCCoreContext (DbContextOptions<SalesMVCCoreContext> options)
            : base(options)
        {
        }

        public DbSet<SalesMVCCore.Models.Departments> Departments { get; set; }
    }
}
