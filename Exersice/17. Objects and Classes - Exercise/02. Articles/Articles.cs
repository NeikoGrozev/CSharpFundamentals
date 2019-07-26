using System;

namespace Articles
{
    class Program
    {
        static void Main()
        {
            string[] article = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Article art = new Article(article[0], article[1], article[2]);

            int numberOfCommand = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommand; i++)
            {
                string[] command = Console.ReadLine()
                    .Split(new string[] { ":  ", ": "}, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Edit")
                {
                    art.Edit(command[1]);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    art.ChangeAuthor(command[1]);
                }
                else if (command[0] == "Rename")
                {
                    art.Remane(command[1]);
                }
            }

            Console.WriteLine(art);

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

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Remane(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
