class Program
{
    class Team
    {
        public Team(string teamName, string ownerName)
        {
            TeamName = teamName;
            OwnerName = ownerName;
            this.TeamMates = new List<string>();
        }

        public string TeamName { get; set; }
        public string OwnerName { get; set; }
        public List<string> TeamMates { get; set; }
    }

    static void Main()
    {
        List<Team> teams = CreateTeams();
        List<Team> members = AddMembersToTeams(teams);
        DisplayTeams(teams, members);
    }

    static List<Team> CreateTeams()
    {
        int amount = int.Parse(Console.ReadLine());
        List<Team> teams = new List<Team>();
        for (int i = 0; i < amount; i++)
        {
            string inputLine = Console.ReadLine();
            string[] inputData = inputLine
                .Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            string creatorName = inputData[0];
            string teamName = inputData[1];
            if (teams.Any(t => t.TeamName == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }
            if (teams.Any(t => t.OwnerName == creatorName))
            {
                Console.WriteLine($"{creatorName} cannot create another team!");
                continue;
            }
            Team team = new Team(teamName, creatorName);
            teams.Add(team);
            Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
        }
        return teams;
    }

    static List<Team> AddMembersToTeams(List<Team> teams)
    {
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end of assignment")
            {
                break;
            }
            string[] inputData = inputLine
                .Split(new[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
            string memberName = inputData[0];
            string teamName = inputData[1];
            if (teams.Any(t => t.TeamName == teamName) == false)
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }
            if (teams.Any(t => t.OwnerName == memberName)
                || teams.Any(t => t.TeamMates.Contains(memberName)))
            {
                Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                continue;
            }
            Team team = teams
                .FirstOrDefault(t => t.TeamName == teamName);
            team.TeamMates.Add(memberName);
        }
        return teams;
    }

    static void DisplayTeams(List<Team> teams, List<Team> members)
    {
        List<Team> orderedTeams = teams
            .Where(t => t.TeamMates.Count > 0)
            .OrderByDescending(t => t.TeamMates.Count)
            .ThenBy(t => t.TeamName)
            .ToList();
        foreach (Team team in orderedTeams)
        {
            Console.WriteLine($"{team.TeamName}");
            Console.WriteLine($"- {team.OwnerName}");
            foreach (var member in team.TeamMates.OrderBy(m => m))
            {
                Console.WriteLine($"-- {member}");
            }
        }
        List<Team> teamsToDisband = teams
            .Where(t => t.TeamMates.Count == 0)
            .ToList();
        Console.WriteLine("Teams to disband:");
        foreach (Team team in teamsToDisband.OrderBy(t => t.TeamName))
        {
            Console.WriteLine(team.TeamName);
        }
    }
}