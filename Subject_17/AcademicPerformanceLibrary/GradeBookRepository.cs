using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademicPerformanceLibrary
{
    public class GradeBookRepository:IGradeBookRepository
    {
        private List<Student> students;

        public GradeBookRepository()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddGrade(int studentId, int grade)
        {
            Student student = students.Find(s => s.StudentId == studentId);
            if (student != null)
            {
                student.Grades.Add(grade);
            }
            else
            {
                throw new ArgumentException("Студент не найден.");
            }
        }

        public double CalculateAverageGrade(int studentId)
        {
            Student student = students.Find(s => s.StudentId == studentId);
            if (student != null)
            {
                if (student.Grades.Count > 0)
                {
                    double sum = student.Grades.Sum();
                    return sum / student.Grades.Count;
                }
                else
                {
                    throw new ArgumentException("Студент не имеет оценок.");
                }
            }
            else
            {
                throw new ArgumentException("Студент не найден.");
            }
        }
    }
}