internal class Program
{
    static void Main(string[] args)
    {

        Dictionary<string, List<string>> wordSynonym = new();

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string world = Console.ReadLine();
            string synonum = Console.ReadLine();

            if (!wordSynonym.ContainsKey(world))
            {
                wordSynonym[world] = new List<string>();
            }

            wordSynonym[world].Add(synonum);
        }

        foreach (KeyValuePair<string, List<string>> word in  wordSynonym)
        {
            Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
        }

        foreach ((string world, List<string> synonum) in wordSynonym)
        {
            Console.WriteLine($"{world} - {string.Join(", ", synonum)}");
        }
            

        
            

        
    }
}
