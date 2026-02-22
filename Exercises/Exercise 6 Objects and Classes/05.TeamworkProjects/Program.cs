
internal class Program
{
    class Team
    {

        public Team(string teamname, string creatorName)
        {
            Name = teamname;
            Creator = creatorName;
            Members = new List<string>();
        }


        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            return $"{Name}\n" +
                   $"- {Creator}\n" +
                   $"{GetMembersString()}";
        }

        private string GetMembersString()
        {
            Members = Members.OrderBy(name => name).ToList();

            string result = "";

            for (int i = 0; i < Members.Count - 1; i++)
            {
                result += $"-- {Members[i]}\n";
            }

            result += $"-- {Members[Members.Count-1]}"; //da unistoji prazniya red


            return result;
        }
    }


    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Team> teams = new List<Team>();

        for(int i = 0; i < n; i++)
        {
            string[] teamCommands = Console.ReadLine().Split("-");
            string teamName = teamCommands[1];
            string creatorName = teamCommands[0];

            Team team = new Team(teamName, creatorName);

            Team sameTeamFound = teams.Find(t => t.Name == teamName);
            if(sameTeamFound != null)
            {
                Console.WriteLine($"Team {team.Name} was already created!");
                continue;
            }

            Team sameCreatorFound = teams.Find(t => t.Creator == creatorName);
            if(sameCreatorFound != null)
            {
                Console.WriteLine($"{team.Creator} cannot create another team!");
                continue;
            }

            teams.Add(team);
            Console.WriteLine($"Team {team.Name} has been created by {team.Creator}!");
        }

        string command;
        while((command = Console.ReadLine()) != "end of assignment")
        {
            string[] arguments = command.Split("->");
            string joinerName = arguments[0];
            string teamName = arguments[1];

            bool hasAnyTeamWithSameName = teams.Any(t => t.Name == teamName);
            if(hasAnyTeamWithSameName == false)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }

            if (teams.Any(team => team.Creator == joinerName) || teams.Any(team => team.Members.Contains(joinerName)))
            {
                Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                continue;
            }

            teams.Find(team=>team.Name == teamName).Members.Add(joinerName);

            //Team t = teams.Find(t=>t.Name == teamName); moje i FirstOrDefault() ili s First()
            //if (t != null)
            //{
            //    t.Members.Add(joinerName);
            //}
        }

        List<Team> leftTeams = teams.Where(team => team.Members.Count > 0).ToList();

        List<Team> disbandTeams = teams.Where(team => team.Members.Count <= 0).ToList();



        List<Team> orderedTeams = leftTeams.OrderByDescending(team => team.Members.Count).ThenBy(t => t.Name).ToList();

        orderedTeams.ForEach(team => Console.WriteLine(team));

      
        Console.WriteLine("Teams to disband:");
        orderedTeams = disbandTeams.OrderBy(t => t.Name).ToList();

        orderedTeams.ForEach(team => Console.WriteLine(team.Name));

    }
}
