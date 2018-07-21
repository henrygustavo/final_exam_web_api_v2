namespace Exam.Domain.Entity.Students
{
    public class StudentMaestria : Student
    {
        public override decimal CalculateScholarship()
        {
            return 200;
        }
    }
}
