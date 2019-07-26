namespace HTML
{
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            string title = Console.ReadLine();
            string article = Console.ReadLine();

            StringBuilder html = new StringBuilder();

            html.AppendLine("<h1>");
            html.AppendLine($"\t{title}");
            html.AppendLine("</h1>");

            html.AppendLine("<article>");
            html.AppendLine($"\t{article}");
            html.AppendLine("</article>");

            while (true)
            {
                string comments = Console.ReadLine();

                if (comments == "end of comments")
                {
                    break;
                }

                html.AppendLine("<div>");
                html.AppendLine($"\t{comments}");
                html.AppendLine("</div>");
            }

            Console.WriteLine(string.Join("", html));
        }
    }
}
