namespace Exam.Infrastructure.Repository.Students
{
    using Exam.Domain.Entity.Students;
    using Exam.Domain.Repository.Students;
    using Exam.Infrastructure.Repository.Common;

    public class StudentPreGradoRepository : BaseRepository<StudentPreGrado>, IStudentPreGradoRepository
    {
        public StudentPreGradoRepository(ApplicationContext context)
                 : base(context)
        {

        }
    }
}
