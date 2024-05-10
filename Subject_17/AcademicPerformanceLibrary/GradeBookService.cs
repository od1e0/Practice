using System;
using System.Collections.Generic;
using System.Linq;

namespace AcademicPerformanceLibrary
{
    public class GradeBookService
    {
        private readonly IGradeBookRepository gradeBookRepository;

        public GradeBookService(IGradeBookRepository gradeBookRepository)
        {
            this.gradeBookRepository = gradeBookRepository;
        }

        public void AddStudent(string name, int studentId)
        {
            Student student = new Student(name, studentId);
            gradeBookRepository.AddStudent(student);
        }

        public void AddGrade(int studentId, int grade)
        {
            gradeBookRepository.AddGrade(studentId, grade);
        }

        public double CalculateAverageGrade(int studentId)
        {
            return gradeBookRepository.CalculateAverageGrade(studentId);
        }
    }
}