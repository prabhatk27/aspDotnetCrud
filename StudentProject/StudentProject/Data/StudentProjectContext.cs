using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentProject.Models;

namespace StudentProject.Data
{
    public class StudentProjectContext : DbContext
    {
        public StudentProjectContext (DbContextOptions<StudentProjectContext> options)
            : base(options)
        {
        }

        public DbSet<StudentProject.Models.Student> Student { get; set; } = default!;
    }
}
