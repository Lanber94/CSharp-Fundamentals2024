using System.Text.Json.Serialization;

int fieldLenght = int.Parse(Console.ReadLine());
int[] bugPlaces = Console.ReadLine().Split().Select(int.Parse).ToArray();

int[] field = new int[fieldLenght];  

for (int i = 0; i < bugPlaces.Length; i++)
{
    int bugIndex = bugPlaces[i];
    if (bugIndex >= 0 && bugIndex <= field.Length - 1)
    {
        field[bugIndex] = 1;
    }
}
string command = "";
while ((command = Console.ReadLine()) != "end")
{
    //0 right 1
    string[] arguments = command.Split();
    int bugIndex = int.Parse(arguments[0]);
    string direction = arguments[1];
    int distance = int.Parse(arguments[2]);

    if (bugIndex >= 0 && bugIndex <= field.Length - 1 && field[bugIndex] == 1)//ako sme validen index, ako ima kalinka
    {
        field[bugIndex] = 0; //mahame kalinkata
        int newPosition;
        if (direction == "right")
        {
            newPosition = bugIndex + distance;//izcislqvame novata poziciya, sprqmo tekustoto mqsto na nasta kalinka + distanciqta koqto trqbva da mine
            while(newPosition >= 0 && newPosition <= field.Length - 1 && field[newPosition] == 1)
            {
                newPosition += distance;
            }
            
            if (newPosition >= 0 && newPosition <= field.Length -1)//ako nqma kalinka
            {
                field[newPosition] = 1;
            }
        }   
        else if (direction == "left")
        {
            newPosition = bugIndex - distance;
            while (newPosition >= 0 && newPosition <= field.Length-1 && field[newPosition] == 1)
            {
                newPosition -= distance;
            }

            if (newPosition >= 0 && newPosition <= field.Length - 1)
            {
                field[newPosition] = 1;
            }

        }
    }
}
Console.WriteLine(string.Join(" ", field));