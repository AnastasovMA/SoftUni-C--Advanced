using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> articles = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] articleData = Console.ReadLine()
                    .Split(", ");

                string title = articleData[0];
                string content = articleData[1];
                string author = articleData[2];

                Article article = new Article();

                article.Title = title;
                article.Content = content;
                article.Author = author;

                articles.Add(article);
            }
            string sortingCriteria = Console.ReadLine();

            List<Article> filteredList = new List<Article>();

            if (sortingCriteria == "title")
            {
                filteredList = articles
                    .OrderBy(x => x.Title)
                    .ToList();
            }
            else if (sortingCriteria == "content")
            {
                filteredList = articles
                    .OrderBy(x => x.Content)
                    .ToList();
            }
            else if (sortingCriteria == "author")
            {
                filteredList = articles
                    .OrderBy(x => x.Author)
                    .ToList();
            }
            foreach (var article in filteredList)
            {
                Console.WriteLine(article);
            }
        }
    }
}
