using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Четем входните списъци
        List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        List<int> resultList = new List<int>();
        
        int minLength = Math.Min(firstList.Count, secondList.Count);
        
        // Добавяме елементите последователно
        for (int i = 0; i < minLength; i++)
        {
            resultList.Add(firstList[i]);
            resultList.Add(secondList[i]);
        }
        
        // Добавяме останалите елементи (ако има такива)
        if (firstList.Count > minLength)
        {
            resultList.AddRange(firstList.Skip(minLength));
        }
        else if (secondList.Count > minLength)
        {
            resultList.AddRange(secondList.Skip(minLength));
        }
        
        // Отпечатваме резултата
        Console.WriteLine(string.Join(" ", resultList));
    }
}

