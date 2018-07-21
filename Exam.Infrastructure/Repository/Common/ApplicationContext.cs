namespace Exam.Infrastructure.Repository.Common
{
    using Exam.Domain.Entity.Students;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):
               base(options)
        {
         
        }
        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<StudentPreGrado> StudentsPregrado { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("students")
                .HasDiscriminator<int>("DegreeType")
                .HasValue<StudentPreGrado>((int) DegreeType.PREGRADO)
                .HasValue<StudentMaestria>((int)DegreeType.MAESTRIA)
                .HasValue<StudentDoctorado>((int)DegreeType.DOCTORADO);
        }
    }
}
