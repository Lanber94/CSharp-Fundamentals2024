int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

int rotation = int.Parse(Console.ReadLine());

for (int i = 0; i < rotation; i++)
{
    int firstNumber = arr[0];

    for (int j = 0; j < arr.Length-1; j++)
    {
        arr[j] = arr[j+1];
    }

    arr[arr.Length-1] = firstNumber;
}                                                                                         //1 pat               //2 pat
Console.WriteLine(string.Join(" ", arr));                       //51 47 32 61 21   -->   47 32 61 21 51 -->  32 61 21 51 47
                                                                







