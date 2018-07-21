namespace Exam.Domain.Entity.Students
{
   public class StudentPreGrado : Student
    {
        public override decimal CalculateScholarship()
        {
            return 100;
        }
    }
}
