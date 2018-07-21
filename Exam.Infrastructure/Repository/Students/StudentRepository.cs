namespace Exam.Infrastructure.Repository.Students
{
    using Exam.Domain.Entity.Students;
    using Exam.Domain.Repository.Students;
    using Exam.Infrastructure.Repository.Common;

    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationContext context)
                 : base(context)
        {

        }
    }
}
