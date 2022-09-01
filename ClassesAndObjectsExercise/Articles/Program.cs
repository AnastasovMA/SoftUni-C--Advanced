using System;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public string Edit(string newContent) 
        {
            return Content = newContent;
        }
        public string ChangeAuthor(string newAuthor)
        {
            return Author = newAuthor;
        }
        public string Rename(string newTitle) 
        {
            return Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine()
                .Split(", ");

            int n = int.Parse(Console.ReadLine());

            string title = articleData[0];
            string content = articleData[1];
            string author = articleData[2];

            Article article = new Article();

            article.Title = title;
            article.Content = content;
            article.Author = author;

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split(": ");

                string command = parts[0];
                string change = parts[1];

                if (command == "Edit")
                {
                    article.Edit(change);
                }
                if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(change);
                }
                if (command == "Rename")
                {
                    article.Rename(change);
                }
            }
            Console.WriteLine(article);
        }
    }
}
