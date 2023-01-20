namespace TheHeist;

public class TeamMemberBuilder
{
    public void Run()
    {
        Console.WriteLine("\r\n _______   __                            __      __                                   __    __            __              __     \r\n/       \\ /  |                          /  \\    /  |                                 /  |  /  |          /  |            /  |    \r\n$$$$$$$  |$$ |  ______   _______        $$  \\  /$$/______   __    __   ______        $$ |  $$ |  ______  $$/   _______  _$$ |_   \r\n$$ |__$$ |$$ | /      \\ /       \\        $$  \\/$$//      \\ /  |  /  | /      \\       $$ |__$$ | /      \\ /  | /       |/ $$   |  \r\n$$    $$/ $$ | $$$$$$  |$$$$$$$  |        $$  $$//$$$$$$  |$$ |  $$ |/$$$$$$  |      $$    $$ |/$$$$$$  |$$ |/$$$$$$$/ $$$$$$/   \r\n$$$$$$$/  $$ | /    $$ |$$ |  $$ |         $$$$/ $$ |  $$ |$$ |  $$ |$$ |  $$/       $$$$$$$$ |$$    $$ |$$ |$$      \\   $$ | __ \r\n$$ |      $$ |/$$$$$$$ |$$ |  $$ |          $$ | $$ \\__$$ |$$ \\__$$ |$$ |            $$ |  $$ |$$$$$$$$/ $$ | $$$$$$  |  $$ |/  |\r\n$$ |      $$ |$$    $$ |$$ |  $$ |          $$ | $$    $$/ $$    $$/ $$ |            $$ |  $$ |$$       |$$ |/     $$/   $$  $$/ \r\n$$/       $$/  $$$$$$$/ $$/   $$/           $$/   $$$$$$/   $$$$$$/  $$/             $$/   $$/  $$$$$$$/ $$/ $$$$$$$/     $$$$/  \r\n                                                                                                                                 \r\n                                                                                                                                 \r\n                                                                                                                                 \r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");

        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("You may have a maximum of 5 team members in your roster.");
        Console.ReadLine();
        Console.Clear();

        List<TeamMember> roster = new List<TeamMember>();

        for (int i = 1; i <= 5; i++)
        {
            TeamMember currentMember = new TeamMember();

            Console.WriteLine($"Member number {i}. Please enter your name.");
            string inputName = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(inputName))
            {
                break;
            }
            currentMember.Name = inputName;

            Console.WriteLine("Please enter your skill level.");
            string inputSkillLevel = Console.ReadLine();
            int skillLevelInt;
            while (!int.TryParse(inputSkillLevel, out skillLevelInt) || skillLevelInt <= 0)
            {
                Console.WriteLine("Skill level must be a positive integer.");
                inputSkillLevel = Console.ReadLine();
            }
            currentMember.SkillLevel = int.Parse(inputSkillLevel);

            Console.WriteLine("Please enter your courage level.");
            string inputCourageLevel = Console.ReadLine();
            double courageLevelDouble;
            while (!double.TryParse(inputCourageLevel, out courageLevelDouble)
                || courageLevelDouble < 0
                || courageLevelDouble > 2
            )
            {
                Console.WriteLine("Courage level must be a decimal number between 0.0 and 2.0");
                inputCourageLevel = Console.ReadLine();
            }
            currentMember.CourageLevel = double.Parse(inputCourageLevel);

            Console.Clear();
            roster.Add(currentMember);
            string welcome = @$"New team member added to roster.

Name: {currentMember.Name}
Skill Level: {currentMember.SkillLevel}
Courage Level: {currentMember.CourageLevel}";

            Console.WriteLine(welcome);
            Console.ReadLine();
            Console.Clear();
        }

        Console.Clear();
        Console.WriteLine($"Here is the current roster, consisiting of {roster.Count} members.\n\n");
        foreach (var member in roster)
        {
            Console.WriteLine(@$"Name: {member.Name}
Skill Level: {member.SkillLevel}
Courage Level: {member.CourageLevel}
");
        }
        Console.ReadLine();

        Console.Clear();
        int bankDifficulty = 100;
        Random randomNum = new Random();
        int luckNum = randomNum.Next(-10, 11);
        bankDifficulty += luckNum;
        int rosterSkillLevel = 0;
        foreach (var member in roster)
        {
            rosterSkillLevel += member.SkillLevel;
        }
        Console.WriteLine($"Bank difficulty: {bankDifficulty}");
        Console.WriteLine($"Roster skill level: {rosterSkillLevel}");
        if (bankDifficulty < rosterSkillLevel)
        {
            Console.WriteLine("You're in for success!");
        }
        else
        {
            Console.WriteLine("This mission won't pan out well for you.");
        }
        Console.ReadLine();
    }
}
