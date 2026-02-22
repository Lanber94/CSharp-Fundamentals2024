// Четем първия ред (масив от елементи)
string[] firstArray = Console.ReadLine().Split();

// Четем втория ред (масив от елементи)
string[] secondArray = Console.ReadLine().Split();

// Използваме LINQ за намиране на общите елементи и извеждаме резултата
var commonElements = secondArray.Intersect(firstArray);

// Извеждаме всички общи елементи
Console.WriteLine(string.Join(" ", commonElements));