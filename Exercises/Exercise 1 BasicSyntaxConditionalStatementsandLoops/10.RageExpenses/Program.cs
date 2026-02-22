int lostGames = int.Parse(Console.ReadLine());  // Number of lost games
float headsetPrice = float.Parse(Console.ReadLine());  // Price of the headset
float mousePrice = float.Parse(Console.ReadLine());  // Price of the mouse
float keyboardPrice = float.Parse(Console.ReadLine());  // Price of the keyboard
float displayPrice = float.Parse(Console.ReadLine());  // Price of the display

// Variables to track how many times each item is trashed
int headsetTrashCount = 0;
int mouseTrashCount = 0;
int keyboardTrashCount = 0;
int displayTrashCount = 0;

// Loop over each lost game to track item trashing
for (int game = 1; game <= lostGames; game++)
{
    if (game % 2 == 0)  // Trashes headset every 2nd game
        headsetTrashCount++;

    if (game % 3 == 0)  // Trashes mouse every 3rd game
        mouseTrashCount++;

    if (game % 2 == 0 && game % 3 == 0)  // Trashes keyboard when both headset and mouse are trashed
        keyboardTrashCount++;
}

// For every 2nd time keyboard is trashed, display also gets trashed
displayTrashCount = keyboardTrashCount / 2;

// Calculate total rage expenses
float totalExpenses = (headsetTrashCount * headsetPrice) +
                      (mouseTrashCount * mousePrice) +
                      (keyboardTrashCount * keyboardPrice) +
                      (displayTrashCount * displayPrice);

Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");




//int lostGames = int.Parse(Console.ReadLine());
//double headsetPrice = double.Parse(Console.ReadLine());
//double mousePrice = double.Parse(Console.ReadLine());
//double keyboardPrice = double.Parse(Console.ReadLine());
//double displayPrice = double.Parse(Console.ReadLine());

////Всяка втора загубена игра, Петър изхвърля слушалките си.
////Всяка трета загубена игра, Петър разбива мишката си.
////Когато Петър изхвърля и мишката, и слушалките си в една и съща загубена игра, той изхвърля и клавиатурата си.
////Всеки втори път, когато изхвърля клавиатурата си, той изхвърля и дисплея си.

//int headsendCount = lostGames / 2;
//int mouseCount = lostGames / 3;

//int keyboardCount = 0;

//if (headsendCount > mouseCount)
//{
//    keyboardCount = mouseCount;
//}
//else
//{
//    keyboardCount = headsendCount;
//}

//int displayCount = keyboardCount / 2;


//double total = (headsendCount * headsetPrice) + (mouseCount * mousePrice) + (keyboardCount * keyboardPrice) + (displayCount * displayPrice);

//Console.WriteLine($"Rage expenses: {total:F2} lv.");


//-------------------------------------------------------//------------------------------------------//--------------------------------------------------------------------//

//int lostGames = int.Parse(Console.ReadLine());  // Брой изгубени игри
//double headsetPrice = double.Parse(Console.ReadLine());  // Цена на наушника
//double mousePrice = double.Parse(Console.ReadLine());  // Цена на мишката
//double keyboardPrice = double.Parse(Console.ReadLine());  // Цена на клавиатурата
//double displayPrice = double.Parse(Console.ReadLine());  // Цена на дисплея

//// Изчисляваме колко пъти ще бъдат изтрошени предметите
//double headsetTrashCount = lostGames / 2;  // На всеки 2-ри път се трошат наушниците
//double mouseTrashCount = lostGames / 3;  // На всеки 3-ти път се трошат мишката
//int keyboardTrashCount = lostGames / 6;  // На всеки 6-ти път се трошат и наушниците, и мишката (т.е. клавиатурата)
//int displayTrashCount = keyboardTrashCount / 2;  // На всеки 2 пъти, когато трошат клавиатурата, се трошат и дисплея

//// Изчисляваме общите разходи
//double totalExpenses = (headsetTrashCount * headsetPrice) +
//                       (mouseTrashCount * mousePrice) +
//                       (keyboardTrashCount * keyboardPrice) +
//                       (displayTrashCount * displayPrice);

//// Печатаме резултата с точност до 2 знака след десетичната запетая
//Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");









