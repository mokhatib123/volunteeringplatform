using Microsoft.EntityFrameworkCore;
using WebApplication10.Models;

namespace WebApplication10.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<WebApplication10.Models.Task> Tasks { get; set; }
        public DbSet<VolunteeringForm> VolunteeringForms { get; set; }
        public DbSet<TrainingCourse> TrainingCourses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
