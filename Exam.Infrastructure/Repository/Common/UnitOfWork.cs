namespace Exam.Infrastructure.Repository.Common
{
    using Exam.Domain.Repository.Common;
    using Exam.Domain.Repository.Students;
    using Exam.Infrastructure.Repository.Students;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;

        public UnitOfWork(ApplicationContext context)
        {
            _context = context;
            Students = new  StudentRepository(_context);
            StudentsPreGrado = new StudentPreGradoRepository(_context);
            StudentsMaestria = new StudentMaestriaRepository(_context);
            StudentsDoctorado = new StudentDoctoradoRepository(_context);

        }

        public IStudentRepository Students { get; }

        public IStudentPreGradoRepository StudentsPreGrado { get; }

        public IStudentMaestriaRepository StudentsMaestria { get; }

        public IStudentDoctoradoRepository StudentsDoctorado { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
