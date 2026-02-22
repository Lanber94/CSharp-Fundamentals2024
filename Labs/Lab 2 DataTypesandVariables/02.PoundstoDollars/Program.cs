decimal pounds = decimal.Parse(Console.ReadLine());

Console.WriteLine($"{pounds * 1.31m:f3}");


decimal pound = decimal.Parse(Console.ReadLine());
decimal rate = 1.31m;
decimal result = pounds * rate;

Console.WriteLine($"{result:f3}");


