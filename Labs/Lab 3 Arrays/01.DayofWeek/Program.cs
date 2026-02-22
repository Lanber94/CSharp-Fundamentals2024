int day = int.Parse(Console.ReadLine()); //[day-1]

string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

if (day >=1 && day <= 7)
{
    int index = day - 1;         
    Console.WriteLine(days[index]); // ili bez index - a s (days[day - 1]
}
else
{
    Console.WriteLine("Invalid day!");
}


Console.WriteLine($"Merhaba Can!");