using System;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor prof1 = new Professor("Alice", "Java", 9000);
            Professor prof2 = new Professor("Bob", "Math", 8000);

            Student student1 = new Student("Lisa", "Java", 90);
            Student student2 = new Student("Tom", "Math", 80);

            Console.WriteLine("Professor Details:");
            Console.WriteLine($"Name: {prof1.ProfName}, Class: {prof1.ClassTeach}, Salary: {prof1.GetSalary()}");
            Console.WriteLine($"Name: {prof2.ProfName}, Class: {prof2.ClassTeach}, Salary: {prof2.GetSalary()}");

            Console.WriteLine("\nStudent Details:");
            Console.WriteLine($"Name: {student1.StudentName}, Enrolled in: {student1.ClassEnroll}, Grade: {student1.GetGrade()}");
            Console.WriteLine($"Name: {student2.StudentName}, Enrolled in: {student2.ClassEnroll}, Grade: {student2.GetGrade()}");

            double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
            Console.WriteLine($"\nSalary Difference between {prof1.ProfName} and {prof2.ProfName}: {salaryDifference}");

            double totalGrade = student1.GetGrade() + student2.GetGrade();
            Console.WriteLine($"Total grade of {student1.StudentName} and {student2.StudentName}: {totalGrade}");
        }
    }

    class Professor
    {
        public string ProfName { get; set; }
        public string ClassTeach { get; set; }
        private double salary;

        public Professor(string name, string classTeach, double salaryAmount)
        {
            ProfName = name;
            ClassTeach = classTeach;
            salary = salaryAmount;
        }

        public void SetSalary(double salaryAmount)
        {
            salary = salaryAmount;
        }

        public double GetSalary()
        {
            return salary;
        }
    }

    class Student
    {
        public string StudentName { get; set; }
        public string ClassEnroll { get; set; }
        private double studentGrade;

        public Student(string name, string classEnroll, double grade)
        {
            StudentName = name;
            ClassEnroll = classEnroll;
            studentGrade = grade;
        }

        public void SetGrade(double newGrade)
        {
            studentGrade = newGrade;
        }

        public double GetGrade()
        {
            return studentGrade;
        }
    }
}
