using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalTest.Models;

namespace FinalTest.Data
{
    public class FinalTestContext : DbContext
    {
        public FinalTestContext (DbContextOptions<FinalTestContext> options)
            : base(options)
        {
        }

        public DbSet<FinalTest.Models.Employee>? Employee { get; set; }
    }
}
