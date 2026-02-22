Console.Write("Length: ");
double length = double.Parse(Console.ReadLine());

Console.Write("Width: ");
double width = double.Parse(Console.ReadLine());

Console.Write("Height: ");
double height = double.Parse(Console.ReadLine());

// Изчисляваме обема на пирамидата
double volume = (length * width * height) / 3;

// Извеждаме резултата
Console.Write($"Pyramid Volume: {volume:f2}"); ;