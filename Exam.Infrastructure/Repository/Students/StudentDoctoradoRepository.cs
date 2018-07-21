namespace Exam.Infrastructure.Repository.Students
{
    using Exam.Domain.Entity.Students;
    using Exam.Domain.Repository.Students;
    using Exam.Infrastructure.Repository.Common;

    public class StudentDoctoradoRepository : BaseRepository<StudentDoctorado>, IStudentDoctoradoRepository
    {
        public StudentDoctoradoRepository(ApplicationContext context)
                 : base(context)
        {

        }
    }
}
