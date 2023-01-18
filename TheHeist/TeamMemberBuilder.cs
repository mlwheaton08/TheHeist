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

        Roster roster = new Roster();

        for (int i = 1; i <= 5; i++)
        {
            TeamMember currentMember = new TeamMember();

            Console.WriteLine($"Member number {i}. Please enter your name.");

            currentMember.Name = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(currentMember.Name))
            {
                break;
            }

            Console.WriteLine("Please enter your skill level.");

            currentMember.SkillLevel = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your courage level.");

            currentMember.CourageLevel = double.Parse(Console.ReadLine());

            Console.Clear();

            roster.members.Add(currentMember);

            string welcome = @$"New team member added to roster.

Name: {currentMember.Name}
Skill Level: {currentMember.SkillLevel}
Courage Level: {currentMember.CourageLevel}";

            Console.WriteLine(welcome);

            Console.ReadLine();

            Console.Clear();
        }

        Console.Clear();

        Console.WriteLine($"Here is the current roster, consisiting of {roster.members.Count} members.\n\n");

        foreach (var member in roster.members)
        {
            Console.WriteLine(@$"Name: {member.Name}
Skill Level: {member.SkillLevel}
Courage Level: {member.CourageLevel}
");
        }

        Console.ReadLine();
    }
}
