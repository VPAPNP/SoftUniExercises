using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace T02_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input= new List<string>();
            input = Console.ReadLine().Split(", ").ToList();
            SortedDictionary<string , double> result = new SortedDictionary<string , double>();
            string patternForName = @"[A-Za-z]";
            string patternForDistance = @"[0-9]";
            
           
            string command;
            while ((command = Console.ReadLine())!= "end of race")
            {
                var sb = new StringBuilder();
                double distance = 0;
                Regex regexNames = new Regex(patternForName);
                Regex regexDigits= new Regex(patternForDistance);
                MatchCollection matchesNames = regexNames.Matches(command);
                MatchCollection matchesDigits= regexDigits.Matches(command);
                foreach ( Match match in matchesNames)
                {
                    if (matchesNames.First() == match)
                    {
                        sb.Append(match.Value.ToUpper());
                    }
                    else
                    {
                        sb.Append(match.Value);
                    }
                    
                }
                string currentName = sb.ToString();
                foreach (Match match1 in matchesDigits)
                {
                    distance += double.Parse(match1.Value);
                }
                if (input.Contains(currentName))
                {
                    if (!result.ContainsKey(currentName))
                    {
                        result.Add(currentName, distance);
                    }
                    else if(result.ContainsKey(currentName))
                    { 
                        result[currentName] += distance; 
                    }
                    
                }
                
            }
            var ordered = result.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine($"1st place: {ordered.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {ordered.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {ordered.Keys.ElementAt(2)}");



        }
    }
}
