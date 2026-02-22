
internal class Program
{
    static void Main(string[] args)
    {
        //Reading Lists from the Console

        int n = int.Parse(Console.ReadLine()); // 3

        List<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine()); //1, 10, 100
            list.Add(number); //[0]->1 [1]->10 [2]->100
        }  

    }
}


    
