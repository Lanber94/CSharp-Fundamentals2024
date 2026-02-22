using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.CompilerServices;

internal class Program
{
    enum Type
    {
        Car,
        Truck
    }

    class Vehicleee
    {

        public Type Type { get; set; }
        public string ModelName { get; set; }
        public string Color { get; set; }
        public double HP { get; set; }
        public Vehicleee(string type, string modelName, string color, string hP)
        {
            Type = type == "car" ? Type.Car : Type.Truck;
            ModelName = modelName;
            Color = color;
            HP = double.Parse(hP);
        }

        public override string ToString()
        {
            return $"Type: {Type}\n"+   
                   $"Model: {ModelName}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {HP}";
        }

    }



    static void Main(string[] args)
    {
        List<Vehicleee> catalogue = new List<Vehicleee>();

        string input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            string[] arguments = input.Split();

            string type = arguments[0];
            string model = arguments[1];
            string color = arguments[2];
            string hP = arguments[3];

            Vehicleee newVehicle = new Vehicleee(type, model, color, hP);

            catalogue.Add(newVehicle);
        }


        while ((input = Console.ReadLine()) != "Close the Catalogue")
        {
            string vehicleModel = input;

            Vehicleee foundVehicle = catalogue.FirstOrDefault(v => v.ModelName == vehicleModel);
            if (foundVehicle != null)
            {
                Console.WriteLine(foundVehicle.ToString());
            }
        }

        double avarageHp = catalogue
            .Where(v => v.Type == Type.Car)
            .Select(c => c.HP)
            .DefaultIfEmpty()
            .Average();
        Console.WriteLine($"Cars have average horsepower of: {avarageHp:f2}.");

        avarageHp = catalogue.Where(v=> v.Type == Type.Truck)
           .Select(t => t.HP)
           .DefaultIfEmpty()
           .Average();
        Console.WriteLine($"Trucks have average horsepower of: {avarageHp:F2}.");
    }
}