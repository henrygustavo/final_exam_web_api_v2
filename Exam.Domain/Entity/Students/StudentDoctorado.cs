namespace Exam.Domain.Entity.Students
{
    public class StudentDoctorado : Student
    {
        public override decimal CalculateScholarship()
        {
             return 300;
        }
    }
}
