using System;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] currArticle = Console.ReadLine().Split(", ");
                Article article = new Article(currArticle[0], currArticle[1], currArticle[2]);
                string currTitle = currArticle[0];
                string currContent = currArticle[1];
                string currAuthor = currArticle[2];

                article.Title = currTitle;
                article.Content = currContent;
                article.Author = currAuthor;

                Console.WriteLine(article);
            }

        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Author = author;
            Title = title;
            Content = content;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}