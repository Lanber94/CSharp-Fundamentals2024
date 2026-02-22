
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
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        
    }

    static void Main(string[] args)
    {
        List<Article> articles= new List<Article>();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] articleProperties = Console.ReadLine().Split(", ");
            string title = articleProperties[0];
            string content = articleProperties[1];
            string author = articleProperties[2];
            Article article = new Article(title, content, author);

            articles.Add(article);
        }

        Console.WriteLine(string.Join("\n", articles));
        


    }
}

