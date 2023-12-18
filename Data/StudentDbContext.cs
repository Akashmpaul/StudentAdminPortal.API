using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.API.Models.DomainModels;

namespace StudentAdminPortal.API.Data
{
    public class StudentDbContext : DbContext
    {
        private readonly DbContextOptions options;

        public StudentDbContext(DbContextOptions options) : base(options)
        {
            this.options = options;
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
