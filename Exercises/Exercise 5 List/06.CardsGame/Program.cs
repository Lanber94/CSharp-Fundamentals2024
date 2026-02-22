using System.ComponentModel;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> player1 = Console.ReadLine().Split().Select(int.Parse).ToList();

        List<int> player2 = Console.ReadLine().Split().Select(int.Parse).ToList();

        while (player1.Count > 0 && player2.Count > 0)
        {
            int player1Card = player1[0];
            int player2Card = player2[0];
            player1.RemoveAt(0);
            player2.RemoveAt(0);

            if (player1Card > player2Card)
            {
               
                player1.Add(player2Card);
                player1.Add(player1Card);
            }
            else if (player1Card < player2Card)
            {
              
                player2.Add(player1Card);
                player2.Add(player2Card);
            }
           
        }

        if (player1.Count > 0)
        {

            Console.WriteLine($"First player wins! Sum: {Sum(player1)}");
        }
        else if (player2.Count > 0)
        {
            Console.WriteLine($"Second player wins! Sum: {Sum(player2)}");
        }
    }

    private static int Sum(List<int> deck)
    {
        int sum = 0;
        for (int i = 0; i < deck.Count; i++)
        {
            sum += deck[i]; 
        }
        return sum;
    }
}
