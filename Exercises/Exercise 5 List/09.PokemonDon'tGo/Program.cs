internal class Program
{
    static void Main(string[] args)
    {
        List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0;
        while (distances.Count > 0)
        {
            int indexToRemove = int.Parse(Console.ReadLine());
            int removeNumber = 0;

            if (indexToRemove < 0)
            {
                removeNumber = distances[0];
                distances[0] = distances[distances.Count - 1];
            }
            else if (indexToRemove > distances.Count - 1)
            {
                removeNumber = distances[distances.Count - 1];//^1 
                distances[distances.Count - 1] = distances[0];
            }
            else
            {
                removeNumber = distances[indexToRemove];
                distances.RemoveAt(indexToRemove);
            }

            sum += removeNumber;

            for (int i = 0; i < distances.Count; i++)
            {
                if (removeNumber >= distances[i])
                {
                    distances[i] += removeNumber;
                }
                else
                {
                    distances[i] -= removeNumber;
                }
            }



        }
        Console.WriteLine(sum);
    }
}