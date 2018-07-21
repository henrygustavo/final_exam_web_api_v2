namespace Exam.Infrastructure.Repository.Students
{
    using Exam.Domain.Entity.Students;
    using Exam.Domain.Repository.Students;
    using Exam.Infrastructure.Repository.Common;

    public class StudentMaestriaRepository : BaseRepository<StudentMaestria>, IStudentMaestriaRepository
    {
        public StudentMaestriaRepository(ApplicationContext context)
                 : base(context)
        {

        }
    }
}
