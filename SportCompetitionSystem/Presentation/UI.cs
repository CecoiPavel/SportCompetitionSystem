using SportCompetitionSystem.Domain;
using SportCompetitionSystem.Domain.Abstractions.Base;
using SportCompetitionSystem.Domain.Services;

namespace SportCompetitionSystem.Presentation;

internal class UI
{
    public static void Menu()
    {
        Lines();
        Console.Write(" 0. Leaderbord  |  ");
        Console.Write("1. Add a Senior Participant  |  ");
        Console.Write("2. Add a Junior Participant  |  ");
        Console.Write("3. Add Staff member  |  ");
        Console.Write("4. Delete Senior/Junior/Staff  |  ");
        Console.WriteLine("5. \u001b[31mExit\u001b[37m");
        Lines();
    }
    private static void Lines()
    {
        int width = Console.WindowWidth;
        Console.WriteLine(new string('-', width));
    }
    public static void Exit()
    {
        Console.Clear();
        ApplicationService.CenterText("See you soon!");
        Environment.Exit(0);
        Console.ReadKey();
    }
    public static void Exception()
    {
        Console.Clear();
        Console.WriteLine();
        ApplicationService.CenterText("Invalid character!");
        ApplicationService.CenterText("Press any key to continue...");
    }
    public static void Delete()
    {
        Console.WriteLine("     Delete a:");
        Console.WriteLine("  1. Senior participant");
        Console.WriteLine("  2. Junior participant");
        Console.WriteLine("  3. Staff member");
        Console.WriteLine("  -------------");
        Console.WriteLine("  4. \u001b[31mExit\u001b[37m");

    }

    public static void ListElement(SportsMan sportsMan)
    {
        var status = sportsMan switch
        {

            JuniorSportsMan => "Junior",
            SeniorSportsMan => "Senior",
            _ => string.Empty

        };
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($" {status} \u001b[31m{sportsMan.Sport} | {sportsMan.Place}\u001b[37m | {sportsMan.Name} | {sportsMan.Country} | \u001b[32m{sportsMan.WonBonus()}$\u001b[0m");
        Console.WriteLine("----------------------------------------------------");
    }

    public static void LeaderBoard(List<SportsMan> sportsMen)
    {
        sportsMen.ForEach(ListElement);
    }

    public static JuniorSportsMan CreateJunior()
    {
        Console.WriteLine("  \u001b[31mInsert Junior details below:\u001b[37m");

        var name = GetStringUserInput("Name : ");
        var age = GetIntUserInput("Age : ");
        var country = GetStringUserInput("Country : ");
        var sport = GetStringUserInput("Sport : ");
        var place = GetIntUserInput("Place: ");

        var junior = new JuniorSportsMan(name, age, country, sport, place);

        Console.WriteLine("\u001b[32m Junior Participant was added! \u001b[0m");

        return junior;
    }

    public static SeniorSportsMan CreateSenior()
    {
        Console.WriteLine("  \u001b[31mInsert Senior details below:\u001b[37m");

        var name = GetStringUserInput("Name : ");
        var age = GetIntUserInput("Age : ");
        var country = GetStringUserInput("Country : ");
        var sport = GetStringUserInput("Sport : ");
        var place = GetIntUserInput("Place: ");

        var senior = new SeniorSportsMan(name, age, country, sport, place);

        Console.WriteLine("\u001b[32m Senior Participant was added! \u001b[0m");

        return senior;
    }

    public static Staff CreateStaff()
    {
        Console.WriteLine("  \u001b[31mInsert Staff member details below:\u001b[37m");

        var name = GetStringUserInput("Name : ");
        var age = GetIntUserInput("Age : ");
        var country = GetStringUserInput("Country : ");
        var sport = GetStringUserInput("Sport : ");
        var role = GetStringUserInput("Staff role: ");

        var staff = new Staff(name, age, country, sport, role);

        Console.WriteLine("\u001b[32m Staff member was added! \u001b[0m");

        return staff;
    }

    public static void DisplayDetails(BaseUser p)
    {
        Console.WriteLine("---------------------------------------------------------");
        Console.Write($" Name: {p.Name}");
        Console.Write($" Age: {p.Age}");
        Console.Write($" Country: {p.Country}");
        Console.Write($" Sport: {p.Sport}");
    }

    //public void JunDetails()
    //{
    //    DisplayDetails();
    //    Console.WriteLine($"Place: {Place}");
    //    Console.WriteLine($"Bonus: {WonBonus()}");
    //    Console.WriteLine($"Promotion status: {IsPromoting()}");
    //}

    public static string? GetStringUserInput(string requestMessage)
    {
        Console.Write(requestMessage);
        var input = Console.ReadLine();
        return input;
    }

    public static int GetIntUserInput(string requestMessage)
    {
        while (true)
        {
            Console.Write(requestMessage);
            var input = Console.ReadLine();
            var isParsed = int.TryParse(input, out var result);

            if(isParsed) return result;

            Console.WriteLine("Error please enter again.");
        }

    }
}
