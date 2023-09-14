using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assessment4.Models;

namespace Assessment4.Data
{
    public class Assessment4DbContext : DbContext
    {
        public Assessment4DbContext (DbContextOptions<Assessment4DbContext> options)
            : base(options)
        {
        }

        public DbSet<Assessment4.Models.Fruit> Fruit { get; set; } = default!;
    }
}
