
using System.Reflection;

internal class Program
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }


        public Article(string title, string content, string author)
        {
            Rename(title);
            Edit(content);
            ChangeAutohor(author);
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        public void Edit(string newContent)
        {

            Content = newContent;
        }

        public void ChangeAutohor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }
    }

    static void Main(string[] args)
    {
        string[] articleProperties = Console.ReadLine().Split(", ");

        string title = articleProperties[0];
        string content = articleProperties[1];
        string author = articleProperties[2];

        Article article = new Article(title, content, author);

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] command = Console.ReadLine().Split(": ");

            switch (command[0])
            {
                case "Edit":
                    string newCount = command[1];
                    article.Edit(newCount);
                    break;
                case "ChangeAuthor":
                    string newAuthor = command[1];
                    article.ChangeAutohor(newAuthor);
                    break;
                case "Rename":
                    string newTitle = command[1];
                    article.Rename(newTitle);
                    break;
            }
        }
        Console.WriteLine(article);

    }
}

