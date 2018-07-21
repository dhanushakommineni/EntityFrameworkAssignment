using EntityFrameWorkAssignment.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EntityFrameWorkAssignment.DataContext
{
    public class StudentData : DbContext
    {
        public DbSet<StudentModel> StudentsDetails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost; Database=Student; Trusted_Connection=True; MultipleActiveResultSets=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
