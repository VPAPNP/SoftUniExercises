using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace T06_Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<decimal>> gradeInfo = new Dictionary<string, List<decimal>>();
            
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                if (!gradeInfo.ContainsKey(name))
                {
                    gradeInfo.Add(name, new List<decimal>());
                    gradeInfo[name].Add(grade);
                }
                else if(gradeInfo.ContainsKey(name))
                {
                    gradeInfo[name].Add(grade);
                }
            }
            
            foreach (var item in gradeInfo)
            {
                
                List<decimal> list = item.Value;
                decimal sumGrade = list.Sum();
                decimal gradeNum = list.Count();
                decimal averageGrade = sumGrade / gradeNum;
                if (averageGrade >= 4.50m)
                {
                    Console.WriteLine($"{item.Key} -> {averageGrade:f2}");
                }
                
            }
        }
    }
}
