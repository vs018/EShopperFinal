using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopper.Models;
using Microsoft.EntityFrameworkCore;

namespace EShopper.Data
{
    public class EShopperContext : DbContext
    {
        public EShopperContext (DbContextOptions<EShopperContext> options)
            : base(options)
        {
        }

        public DbSet<Vegetables> Vegetables { get; set; }

        public DbSet<Seeds> Seeds { get; set; }

        public DbSet<Fruits> Fruits { get; set; }
    }
}
