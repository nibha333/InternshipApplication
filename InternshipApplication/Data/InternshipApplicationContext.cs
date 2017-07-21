using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InternshipApplication.Models.NewFolder1;

namespace InternshipApplication.Models
{
    public class InternshipApplicationContext : DbContext
    {
        public InternshipApplicationContext (DbContextOptions<InternshipApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<InternshipApplication.Models.NewFolder1.MainApplication> MainApplication { get; set; }
    }
}
