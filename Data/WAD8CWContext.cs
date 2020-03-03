using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WAD8CW.Models;

namespace WAD8CW.Data
{
    public class WAD8CWContext : DbContext
    {
        public WAD8CWContext (DbContextOptions<WAD8CWContext> options)
            : base(options)
        {
        }

        public DbSet<WAD8CW.Models.Student> Student { get; set; }
    }
}
