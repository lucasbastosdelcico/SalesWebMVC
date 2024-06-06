using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models.ViewModel;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMVC.Models.ViewModel.Department> Department { get; set; } = default!;
    }
}
