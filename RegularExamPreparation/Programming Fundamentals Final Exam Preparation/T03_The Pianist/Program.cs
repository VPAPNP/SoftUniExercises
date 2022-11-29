using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace T03_The_Pianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Pieces> listPieces = new List<Pieces>();
            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split("|",StringSplitOptions.RemoveEmptyEntries);
                string pieceName = input[0];
                string composer = input[1];
                string key = input[2];
                Pieces piece = new Pieces(pieceName, composer, key);
                listPieces.Add(piece);
            }
            string command;
            while ((command = Console.ReadLine())!= "Stop")
            {
                string[] commandArg = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArg[0];
                string pieceName = commandArg[1];
                if (action == "Add")
                {
                    string composer = commandArg[2];
                    string key = commandArg[3];
                    bool contains = false;
                    foreach (var item in listPieces)
                    {
                        if (item.PieceName == pieceName)
                        {
                            Console.WriteLine($"{pieceName} is already in the collection!");
                            contains = true;
                        }
                    }
                    if (contains == false)
                    {
                        Pieces piece = new Pieces(pieceName, composer, key);
                        listPieces.Add(piece);
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                }
                else if (action == "Remove")
                {
                    bool contains = false;
                    foreach (var item in listPieces)
                    {
                        if (item.PieceName == pieceName)
                        {
                            
                            Console.WriteLine($"Successfully removed {pieceName}!");
                            contains = true;
                            
                            break;
                        }
                    }
                    if (contains == false)
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                    else
                    {
                        int indexOfPiece = listPieces.IndexOf(listPieces.Single(i => i.PieceName == pieceName));
                        Pieces piece = listPieces[indexOfPiece];
                        listPieces.Remove(piece);
                    }
                    
                }
                else if (action == "ChangeKey")
                {
                    string newKey = commandArg[2];
                    int indexOfPiece = listPieces.IndexOf(listPieces.Single(i => i.PieceName == pieceName));
                    Pieces piece = listPieces[indexOfPiece];
                        if (listPieces.Exists(x=> x.PieceName == pieceName))
                        {
                            piece.Key = newKey;
                            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }
                }
            }
            foreach (Pieces pieces in listPieces)
            {
                
                Console.WriteLine($"{pieces.PieceName} -> Composer: {pieces.Composer}, Key: {pieces.Key}");
            }
        }
    }
    public class Pieces
    {
        public Pieces(string pieceName,string composer, string key) 
        {
            PieceName= pieceName;
            Composer= composer;
            Key= key;
        }
        public string PieceName { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }
    }
}
