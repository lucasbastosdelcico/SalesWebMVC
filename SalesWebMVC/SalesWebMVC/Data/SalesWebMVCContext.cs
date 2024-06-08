﻿using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;

        public DbSet<Seller> Sellers { get; set; } = default!;  

        public DbSet<SalesRecord> SalesRecords { get; set; } = default!;
    }
}
