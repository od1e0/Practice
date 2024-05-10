using System.Collections.Generic;

namespace AcademicPerformanceLibrary
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public List<int> Grades { get; set; }

        public Student(string name, int studentId)
        {
            Name = name;
            StudentId = studentId;
            Grades = new List<int>();
        }
    }
}