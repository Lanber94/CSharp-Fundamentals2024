internal class Program
{
/*
SoftUni -> AA12345
SoftUni -> BB12345
Microsoft -> CC12345
HP -> BB12345
End
*/

    class Company
    {
        public string Name { get; }
        public List<string> EmployeeIds { get; set; }
        public Company(string name)
        {
            Name = name;
            EmployeeIds = new List<string>();
        }

        public override string ToString()
        {
            string result = $"{Name}";
            for(int i = 0; i < EmployeeIds.Count; i++)
            {
                result += ($"\n-- {EmployeeIds[i]}");
            } 
            return result; 
        }

        public void AddEmployeeId(string id)
        {
            if(!EmployeeIds.Contains(id))
            {
                EmployeeIds.Add(id);
            }
        }

    }

    static void Main(string[] args)
    {
         //List<Company> companies = new List<Company>();  
         Dictionary<string, Company> companies = new Dictionary<string, Company>();

        string command = "";
        while ((command = Console.ReadLine()) != "End")
        {
            string[] arguments = command.Split(" -> ");
            string companyName = arguments[0];
            string Id = arguments[1];

            if (!companies.ContainsKey(companyName))
            {
                companies.Add(companyName, new Company(companyName));
                
            }
           
            
                companies[companyName].AddEmployeeId(Id);

        }
      

        foreach (Company company in companies.Values)
        {
            Console.WriteLine(company);
        }

        //foreach (var company in companies)
        //{
        //    Console.WriteLine(company.Value);
            
        //}
    }
}