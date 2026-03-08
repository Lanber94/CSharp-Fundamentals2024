namespace _09_Training;

public class Program
{
    static void Main(string[] args)
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int sum = 0;

        while (list.Count > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int removed = 0;

            if (n < 0)
            {
                removed = list[0];
                int last = list[list.Count - 1];
                list.RemoveAt(0);
                list.Insert(0, last);
            }
            else if (n >= list.Count)
            {
                removed = list[list.Count - 1];
                int first = list[0];
                list.RemoveAt(list.Count - 1);
                list.Add(first);
            }
            else
            {
                removed = list[n];
                list.RemoveAt(n);
            }

            sum += removed;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= removed)
                {
                    list[i] += removed;
                }
                else
                {
                    list[i] -= removed;
                }
            }
        }

        Console.WriteLine(sum);
    }
}