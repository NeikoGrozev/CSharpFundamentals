using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            List<Article> art = new List<Article>();

            for (int i = 0; i < num; i++)
            {
                string[] word = Console.ReadLine()
                    .Split(", ");

                string title = word[0];
                string content = word[1];
                string author = word[2];

                Article articles = new Article(title, content, author);

                art.Add(articles);
            }

            string command = Console.ReadLine();

            if (command == "title")
            {
               art = art.OrderBy(x => x.Title).ToList();
            }
            else if (command == "content")
            {
                art = art.OrderBy(x => x.Content).ToList();
            }
            else if (command == "author")
            {
                art = art.OrderBy(x => x.Author).ToList();
            }

            foreach (Article a in art)
            {
                Console.WriteLine(a);
            }
        }
    }

    class Article
    {
        public string Title { get; set; }
        
        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
