using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace T06_Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] listSongs = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(listSongs);
            
            while (queue.Count > 0)
            {
                string[] commandInputSplit = Console.ReadLine().Split(" ").ToArray();
                
                string command = commandInputSplit[0];
                if (command == "Play")
                {
                    queue.Dequeue();
                }
                else if (command == "Add")
                {
                    string currSong = String.Join(" ", commandInputSplit.Skip(1));
                    
                    if (!queue.Contains(currSong))
                    {
                        queue.Enqueue(currSong);
                    }
                }
                else if (command == "Show")
                {
                    if (queue.Count > 0)
                    {
                        Console.WriteLine(string.Join(", ", queue));                    }
                    
                }

            }
            Console.WriteLine("No more songs!");
        }
    }
}
