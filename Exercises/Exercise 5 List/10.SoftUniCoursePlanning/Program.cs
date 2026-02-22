using System;
using System.Data;
using System.Text.Json.Serialization;

internal class Program
{
    static void Main()
    {
        List<string> schedule = Console.ReadLine().Split(", ").ToList();

        string command = "";
        while ((command = Console.ReadLine()) != "course start") ;
        {
            string[] arguments = command.Split(':');
            if (arguments[0] == "Add")
            {
                schedule = AddTitle(schedule, arguments[1]);
            }
            else if (arguments[0] == "Insert")
            {
                schedule = InsertTitle(schedule, arguments[1], int.Parse(arguments[2]));
            }
            else if (arguments[0] == "Remove")
            {
                schedule = RemoveTitle(schedule, arguments[1]);
            }
            else if (arguments[0] == "Swap")
            {
                schedule = SwapTitles(schedule, arguments[1], arguments[2]);
            }
            else if (arguments[0] == "Exercise")
            {
                schedule = InsertExercise(schedule, arguments[1]);
            }

            
        }

        Console.WriteLine(PrintSchedule(schedule));
    }

    private static string PrintSchedule(List<string> schedule)
    {
        string result = "";
        for (int i = 0; i < schedule.Count; i++)
        {
            Console.WriteLine($"{i + 1}.{schedule[i]}");
        }
        return result;
    }

    private static List<string> InsertExercise(List<string> schedule, string title)
    {
        string exercsieTitle = $"{title}-Exercisie";
        if (!schedule.Contains(title))
        {
            AddTitle(schedule, title);
        }

        if (schedule.Contains(title) && !schedule.Contains(exercsieTitle))
        {
            int index  = schedule.FindIndex(x => x == title);
            InsertTitle(schedule, exercsieTitle, index + 1);
        }

        return schedule;
    }
    private static List<string> SwapTitles(List<string> schedule, string firstTitle, string secondTitle)
    {
        if(schedule.Contains(firstTitle) && schedule.Contains(secondTitle))
        {
            int firstIndex = schedule.FindIndex(lesson  => lesson == firstTitle);
            int secondIndex = schedule.FindIndex(lesson => lesson == secondTitle);

            string temp = schedule[firstIndex];
            schedule[firstIndex] = schedule[secondIndex];
            schedule[secondIndex] = temp;

            //TODO: Swap the exercise too
            //dopulnitelen metod

            schedule = SwapExercise(schedule, firstTitle, secondIndex);
            schedule = SwapExercise(schedule, secondTitle, firstIndex);
                
        }

        return schedule;
    }

    private static List<string> SwapExercise(List<string> schedule, string title, int titleIndex)
    {
        string exerciseTitle = $"{title}-Exercise";
        int index = schedule.FindIndex(l => l == exerciseTitle);
        if (index >= 0)
        {
            RemoveTitle(schedule, exerciseTitle);
            InsertTitle(schedule, exerciseTitle, titleIndex + 1);
        }

        return schedule;
    }

    private static List<string> RemoveTitle(List<string> schedule, string title)
    {
        schedule.Remove(title);

        string exerciseTitle = $"{title}-Exercise";
        int index = schedule.FindIndex(x => x == exerciseTitle);

        if (index >= 0)
        {
            RemoveTitle(schedule, exerciseTitle);
        }

        return schedule;
    }

    private static List<string> InsertTitle(List<string> schedule, string title, int index)
    {
        if (!schedule.Contains(title))
        {
            schedule.Insert(index, title);
        }

        return schedule;
    }

    private static List<string> AddTitle(List<string> schedule, string title)
    {
        if (!schedule.Contains(title))
        {
            schedule.Add(title);
        }

        return schedule;
    }
}