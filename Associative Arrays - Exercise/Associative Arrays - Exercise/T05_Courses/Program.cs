using System;
using System.Collections.Generic;

namespace T05_Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> coursesInfo = new Dictionary<string, List<string>>();

            string command;

            while ((command = Console.ReadLine())!= "end")
            {
                string[] commandInfo = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string courseName = commandInfo[0];
                string studentName = commandInfo[1];
                if (!coursesInfo.ContainsKey(courseName))
                {
                    coursesInfo.Add(courseName,new List<string>());
                }
                 coursesInfo[courseName].Add(studentName);

            }
            foreach (var kvp in coursesInfo)
            {
                List<string> students = kvp.Value;
                Console.WriteLine($"{kvp.Key}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");

                }
            }

        }
    }
}
