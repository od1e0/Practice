using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademicPerformanceLibrary
{
    public class GradeBook
    {
        private IGradeBookRepository repository;

        public GradeBook(IGradeBookRepository repository)
        {
            this.repository = repository;
        }

        public void AddStudent(string name, int studentId)
        {
            var student = new Student(name, studentId);
            repository.AddStudent(student);
        }

        public void AddGrade(int studentId, int grade)
        {
            var student = repository.GetStudent(studentId);
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
            var student = repository.GetStudent(studentId);
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