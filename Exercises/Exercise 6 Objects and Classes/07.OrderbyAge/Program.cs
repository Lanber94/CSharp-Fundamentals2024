internal class Program
{
    class Info
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int  Age { get; set; }

        public Info(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age =age;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";

        }
    }

    static void Main(string[] args)
    {
        List<Info> information = new List<Info>();

        string input = "";
        while ((input = Console.ReadLine()) != "End")
        {
            string[] data = input.Split();

            string name = data[0];
            string id = data[1];
            int age = int.Parse(data[2]);

            Info existInfo = information.FirstOrDefault(x => x.Id == id);
            if(existInfo != null)
            {
                existInfo.Age = age;
                existInfo.Name = name;
            }
            else
            {
                Info newInfo = new Info(name, id, age);
                information.Add(newInfo);
            }
        }

        information = information.OrderBy(x => x.Age).ToList();

        foreach (var person in information)
        {
            Console.WriteLine(person);
        }
    }
}