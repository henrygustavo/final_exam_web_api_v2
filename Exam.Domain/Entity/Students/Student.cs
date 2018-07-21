namespace Exam.Domain.Entity.Students
{
    public abstract class Student
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public int DegreeType { get; set; }
        public virtual decimal  CalculateScholarship()
        {
            return 0;
        }
    }

}
