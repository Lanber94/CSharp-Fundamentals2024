
internal class Program
{
    static void Main(string[] args)
    {
        // İlk satırı okuyup vagonların yolcu sayılarını bir listeye çeviriyoruz
        List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();

        // Maksimum kapasiteyi okuyoruz
        int maxCapacity = int.Parse(Console.ReadLine());

        string command;
        while ((command = Console.ReadLine()) != "end")
        {
            // Komut "Add" ile başlıyorsa yeni bir vagon ekliyoruz
            if (command.StartsWith("Add"))
            {
                int passengersToAdd = int.Parse(command.Split()[1]);
                wagons.Add(passengersToAdd);
            }
            else
            {
                // Yoksa mevcut vagonlara yolcu eklemeye çalışıyoruz
                int passengers = int.Parse(command);
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (wagons[i] + passengers <= maxCapacity)
                    {
                        wagons[i] += passengers;
                        break;  // İlk uygun vagona ekleyip çıkıyoruz
                    }
                }
            }
        }

        // Son durumu ekrana basıyoruz
        Console.WriteLine(string.Join(" ", wagons));
    }
}

