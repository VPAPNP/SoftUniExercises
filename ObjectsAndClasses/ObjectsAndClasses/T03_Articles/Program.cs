using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace T03_Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            int num = int.Parse(Console.ReadLine());
            string content = input[1];
            string author = input[2];
            string title = input[0];    
            
            Article article = new Article(title, content, author);

            for (int i = 0; i < num; i++)
            {
                string[] commandArg = Console.ReadLine().Split(": ",StringSplitOptions.RemoveEmptyEntries);
                
                
                if (commandArg[0] == "Edit")
                {
                    article.Edit(commandArg[1]);

                }
                else if (commandArg[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commandArg[1]);
                }
                else if (commandArg[0] == "Rename")
                {
                    article.Rename(commandArg[1]);
                }
            }
            Console.WriteLine(article.ToString());
                

        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content; 
            this.Author = author;
           
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        

        
        

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        public void Edit(string newContent)
        {
            this.Content = newContent;
        }
        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }
        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }
    }
}
