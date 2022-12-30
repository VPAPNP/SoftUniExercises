using System;
using System.Collections.Generic;
using System.Linq;

namespace T05_Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < count; i++)
            {
                string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstName = info[0];
                string lastName = info[1];
                decimal grade = decimal.Parse(info[2]);
                Student currStudent = new Student(firstName, lastName, grade);
                students.Add(currStudent);
            }
            List<Student> ordered = students
                .OrderByDescending(x => x.Grade)
                .ToList();
            foreach (Student student in ordered)
            {
                Console.WriteLine(student);
            }
        }
    }
    public class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade}";
        }
    }

    
        
   
}
