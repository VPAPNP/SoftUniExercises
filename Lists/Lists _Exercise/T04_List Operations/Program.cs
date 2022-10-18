    using System;
    using System.Collections.Generic;
using System.Linq;
    using System.Reflection;

    namespace T04_List_Operations
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<int> ints = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
                string comands;
                while ((comands = Console.ReadLine()) != "End")
                {
                    string[] cmdArgs = comands.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                    if (cmdArgs.Contains("Add"))
                    {
                        ints.Add(int.Parse(cmdArgs[1]));
                    }
                    else if (cmdArgs.Contains("Insert"))
                    {
                        int index = int.Parse(cmdArgs[2]);
                        if (index < 0 || index >= ints.Count )
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            ints.Insert(index, int.Parse(cmdArgs[1]));
                        }
                    }
                    else if (cmdArgs.Contains("Remove"))
                    {
                        int index = int.Parse(cmdArgs[1]);
                        if (index < 0 || index >= ints.Count)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        else
                        {
                            ints.RemoveAt(index);
                        }
                    }
                    else if (cmdArgs.Contains("left"))
                    {
                        int count = int.Parse(cmdArgs[2]);
                      if (count >0 )
                      {
                        for(int i = 0; i < count; i++)
                        {


                            ints.Add(ints[0]);
                            ints.Remove(ints[0]);

                        }
                      }
                        
                    }
                    else if (cmdArgs.Contains("right"))
                    {
                    int count = int.Parse(cmdArgs[2]);
                    if (count > 0)
                    {
                        int lastNum = ints[ints.Count - 1];
                        for (int k = 0; k < count; k++)
                        {
                            ints.Insert(0, ints[ints.Count -1]);
                            int last = ints[ints.Count - 1];
                            ints.RemoveAt(ints.Count -1 );
                            
                        }
                    }
                        
                        
                    }
                }
                Console.WriteLine(string.Join(" ", ints));
            }
        }
    }
