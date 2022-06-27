using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeBase_5.Models;

namespace CodeBase_5.Data
{
    public class CodeBase_5Context : DbContext
    {
        public CodeBase_5Context (DbContextOptions<CodeBase_5Context> options)
            : base(options)
        {
        }

        public DbSet<CodeBase_5.Models.Student> Student { get; set; }
    }
}
