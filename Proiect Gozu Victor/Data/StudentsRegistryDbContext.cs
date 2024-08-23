using Microsoft.EntityFrameworkCore;
using Proiect_Gozu_Victor.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Proiect_Gozu_Victor.Data
{
    public class StudentsRegistryDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public StudentsRegistryDbContext(DbContextOptions<StudentsRegistryDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
