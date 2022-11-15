using System;


namespace _01._World_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string  input = Console.ReadLine();
            string commands;
            while ((commands = Console.ReadLine()) != "Travel")
            {
                string[] commandInfo = commands.Split(':');
                if (commandInfo[0] == "Add Stop")
                {
                    AddStop(ref input, commandInfo);
                   
                }
                else if (commandInfo[0] == "Remove Stop")
                {
                    RemoveStop( ref input, commandInfo);
                }
                else if (commandInfo[0] == "Switch")
                {
                    Switch( ref input, commandInfo);
                   
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {input}");

        }

        public static void RemoveStop(ref string input, string[] commandInfo)
        {
            
            int startIndex = int.Parse(commandInfo[1]);
            int endIndex = int.Parse(commandInfo[2]);
            if (startIndex >= 0 && startIndex < input.Length  && endIndex >= 0 && endIndex < input.Length)
            {
                int rangeToRemove = endIndex - startIndex;
                input = input.Remove(startIndex, rangeToRemove + 1 );
                
            }
            Console.WriteLine(input);

        }

        public static void AddStop(ref string input, string[] commandInfo)
        {
            
                int index = int.Parse(commandInfo[1]);
                string stringToInsert = commandInfo[2];
                if (index >= 0 && index < input.Length )
                {
                    input = input.Insert(index, stringToInsert);
                   
                }
            Console.WriteLine(input);

        }
        public static void Switch(ref string input, string[] commandInfo)
        {
           
            if (input.Contains(commandInfo[1]))
            {
                
                    input = input.Replace(commandInfo[1], commandInfo[2]);
                
                    
                
                
            }
            Console.WriteLine(input);

        }
    }
}
