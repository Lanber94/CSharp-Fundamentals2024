
internal class Program
{
    //Premahvane otricatelni, polojitelni, ili cetni ili ne cetni cisla. kakvoto si iskame..
    static void Main(string[] args)
    {
        
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        numbers.RemoveAll(nunber => nunber < 0);
        numbers.Reverse();

        if (numbers.Count == 0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", numbers));
        }
       
    }
}

