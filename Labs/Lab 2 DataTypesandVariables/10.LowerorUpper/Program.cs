char inputChar = char.Parse(Console.ReadLine());

// Проверка дали символът е главна или малка буква
if (inputChar >= 'A' && inputChar <= 'Z')
{
    Console.WriteLine("upper-case");
}
else if (inputChar >= 'a' && inputChar <= 'z')
{
    Console.WriteLine("\nlower-case");
}