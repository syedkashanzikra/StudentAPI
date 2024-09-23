using KashanPractical.Models;
using Microsoft.EntityFrameworkCore;

namespace KashanPractical.Context
{
   

    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }

}
