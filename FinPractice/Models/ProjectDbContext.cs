using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinPractice.Models
{
    public class ProjectDbContext: DbContext
    {
        public ProjectDbContext()
        {

        }

        public ProjectDbContext(DbContextOptions<ProjectDbContext> options): base(options)
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
