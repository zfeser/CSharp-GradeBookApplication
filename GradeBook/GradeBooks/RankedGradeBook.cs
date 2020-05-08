using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
    public void GetLetterGrade(double averageGrade)
    {
       if (double.IsNullOrEmpty(student.Name))
                throw new ArgumentException("A Name is required to add a student to a gradebook.");
    Students.Add(student);
    }
}
