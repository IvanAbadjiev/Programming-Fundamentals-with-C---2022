namespace P02._Articles
{
using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();
            int n = int.Parse(Console.ReadLine());
                string title = text[0];
                string conttent = text[1];
                string author = text[2];
            Article article = new Article(title, conttent, author);
            
              
            for (int i = 0; i < n; i++)
            {

                string[] cmdArgs = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries);


                string command = cmdArgs[0];
                string newValue = cmdArgs[1];
                 
                if (command == "Edit")
                {
                    article.Edit(newValue);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(newValue);
                }
                else if (command == "Rename")
                {
                    article.Rename(newValue);
                }


            }
            Console.WriteLine(article);

        }
    }

    public class Article
    {

        public Article(string title, string content, string autrhor)
        {
            Title = title;
            Content = content;
            Autrhor = autrhor;
        }

        public string Title { get; private  set; }
        public string Content { get; private set; }
        public string Autrhor { get; private set; }

        public void Edit(string newContent)
        {
            Content = newContent;

        }
        public void ChangeAuthor(string newAutrhor)
        {
            Autrhor = newAutrhor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autrhor}";
        }


    }
}
