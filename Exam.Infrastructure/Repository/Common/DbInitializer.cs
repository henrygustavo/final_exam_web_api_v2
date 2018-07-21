namespace Exam.Infrastructure.Repository.Common
{
    using System.Threading.Tasks;
    using System.Linq;
    using Exam.Domain.Entity.Students;

    public class DbInitializer
    {
        private readonly ApplicationContext _context;

        public DbInitializer(ApplicationContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        public async Task Seed()
        {
            SeedStudents();
            await _context.SaveChangesAsync();
        }

        public void SeedStudents()
        {
            if (!_context.Students.Any(p => p.Name == "Henry")) {

                var student = new StudentPreGrado();
                student.Name = "Henry";

                _context.Students.Add(student);
            }

            if (!_context.Students.Any(p => p.Name == "Juan"))
            {

                var student = new StudentPreGrado();
                student.Name = "Juan";

                _context.Students.Add(student);
            }

            if (!_context.Students.Any(p => p.Name == "Gustavo"))
            {
                var student02 = new StudentMaestria();
                student02.Name = "Gustavo";

                _context.Students.Add(student02);
            }

            if (!_context.Students.Any(p => p.Name == "Pablo"))
            {
                var student03 = new StudentMaestria();
                student03.Name = "Pablo";

                _context.Students.Add(student03);
            }

            if (!_context.Students.Any(p => p.Name == "Carlos"))
            {
                var student04 = new StudentDoctorado();
                student04.Name = "Carlos";

                _context.Students.Add(student04);
            }

            if (!_context.Students.Any(p => p.Name == "Santos"))
            {
                var student05 = new StudentDoctorado();
                student05.Name = "Santos";

                _context.Students.Add(student05);
            }
        }
    }
}
