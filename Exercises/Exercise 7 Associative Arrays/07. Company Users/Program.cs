internal class Program
{
/*
SoftUni -> AA12345
SoftUni -> BB12345
Microsoft -> CC12345
HP -> BB12345
End
*/

    

    static void Main(string[] args)
    {
        Dictionary<string, List<string>> employeeIds = new Dictionary<string, List<string>>();

        string command = "";
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split(" -> ");
            string companyName = arguments[0];
            string Id = arguments[1];

            if (!employeeIds.ContainsKey(companyName))
            {
                employeeIds.Add(companyName, new List<string>());
                //employeeIds[companyName] = new List<string>();
            }
            if (!employeeIds[companyName].Contains(Id))
            {
                employeeIds[companyName].Add(Id);

            }


        }

        foreach (KeyValuePair<string, List<string>> company in employeeIds)
        {
            Console.WriteLine(company.Key);
            for (int i = 0; i < company.Value.Count; i++)
            {
                Console.WriteLine($"-- {company.Value[i]}");
            }
        }
    }
}