using Microsoft.EntityFrameworkCore;

namespace Artesia.Model
{
    public class ArtesiaContext : DbContext
    {
        public ArtesiaContext(DbContextOptions<ArtesiaContext> options) : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        // public DbSet<Enrollment> Enrollments { get; set; }
        // public DbSet<Student> Students { get; set; }
    }
}