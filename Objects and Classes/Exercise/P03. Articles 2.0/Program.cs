
namespace P03._Articles_2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Article> articleList = new List<Article>();
            for (int i = 0; i < n; i++)
            {
            List<string> text = Console.ReadLine()
                  .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                  .ToList();

            string title = text[0];
            string conttent = text[1];
            string author = text[2];

            Article article = new Article(title, conttent, author);
                articleList.Add(article);

               

               

            }
            Console.WriteLine(string.Join(Environment.NewLine, articleList));

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

        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Autrhor { get; private set; }

        //public void Edit(string newContent)
        //{
        //    Content = newContent;

        //}
        //public void ChangeAuthor(string newAutrhor)
        //{
        //    Autrhor = newAutrhor;
        //}
        //public void Rename(string newTitle)
        //{
        //    Title = newTitle;
        //}
        public override string ToString()
        {
            return $"{Title} - {Content}: {Autrhor}";
        }


    }
}
