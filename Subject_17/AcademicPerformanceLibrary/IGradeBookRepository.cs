namespace AcademicPerformanceLibrary
{
    public interface IGradeBookRepository
    {
        void AddStudent(Student student);
        void AddGrade(int studentId, int grade);
        double CalculateAverageGrade(int studentId);
    }
}