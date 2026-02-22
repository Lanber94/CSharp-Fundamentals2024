using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main(string[] args)
    {
        // Read the input sequence of numbers
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

        // Read the bomb number and its power
        int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int bombNumber = bombInfo[0];
        int bombPower = bombInfo[1];

        // Detonate bombs
        while (numbers.Contains(bombNumber))
        {
            int bombIndex = numbers.IndexOf(bombNumber);

            // Calculate the range to be removed
            int start = Math.Max(0, bombIndex - bombPower);
            int end = Math.Min(numbers.Count - 1, bombIndex + bombPower);

            // Remove elements within the range
            numbers.RemoveRange(start, end - start + 1);
        }

        // Print the sum of remaining numbers
        Console.WriteLine(numbers.Sum());
    }
}