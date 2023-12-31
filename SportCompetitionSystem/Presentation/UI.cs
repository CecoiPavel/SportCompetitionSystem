﻿using SportCompetitionSystem.Domain;
using SportCompetitionSystem.Domain.Services;

namespace SportCompetitionSystem.Presentation;

internal class UI
{
    public static void Interface(List <SeniorSportsMan> seniorslist, List <JuniorSportsMan> juniorslist, List<Staff> stafflist)
    {
        Menu();

        int option = Convert.ToInt32(Console.ReadLine());

        Menu();

        switch (option)
        {
            case 0:
                LeaderbordOptions(seniorslist, juniorslist, stafflist);
                ReturnKey();
                break;

            case 1:
                var senior = CreateSenior();
                seniorslist.Add(senior);
                SeeSeniors(seniorslist);
                ReturnKey();
                break;

            case 2:
                var junior = CreateJunior();
                juniorslist.Add(junior);
                ReturnKey();
                break;

            case 3:
                var staff = CreateStaff();
                stafflist.Add(staff);
                ReturnKey();
                break;

            case 4:
                DeleteListOptions(seniorslist, juniorslist, stafflist);
                ReturnKey();
                break;

            case 5:
                ReturnKey();
                return;
        }
    }
    public static void Menu()
    {
        Console.WindowWidth = 150;
        Console.WindowHeight = 30;
        Console.Clear();
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
    public static void Exception()
    {
        Console.Clear();
        Console.WriteLine();
        ApplicationService.CenterText("Invalid character!");
        ApplicationService.CenterText("Press any key to continue...");
    }
    public static int DeleteMenu()
    {
        Console.WriteLine("     Delete a:");
        Console.WriteLine("  1.  Senior sportsman");
        Console.WriteLine("  2.  Junior sportsman");
        Console.WriteLine("  3.  Staff member");
        Console.WriteLine("  -------------");
        Console.WriteLine("  4. \u001b[31mExit\u001b[37m");

        var choice = GetIntUserInput("Insert your choice : ");

        return choice;
    }
    public static int LeaderbordMenu()
    {
        Console.WriteLine("  1.  See Seniors Leaderbord");
        Console.WriteLine("  2.  See Juniors Leaderbord");
        Console.WriteLine("  3.  See Staff members");
        Console.WriteLine("  -------------");
        Console.WriteLine("  4. \u001b[31mExit\u001b[37m");

        var choice = GetIntUserInput("Insert your choice : ");

        return choice;
    }

    public static void DeleteListOptions(List<SeniorSportsMan> senior, List<JuniorSportsMan> junior, List<Staff> staff)
    {
        var choice = DeleteMenu();

        Menu();

        switch (choice)
        {
            case 1:
                SeeSeniors(senior);
                DeleteSenior(senior);
                SeeSeniors(senior);
                break;
            case 2:
                SeeJuniors(junior);
                DeleteJunior(junior);
                SeeJuniors(junior);
                break;
            case 3:
                SeeStaff(staff);
                DeleteStaff(staff);
                SeeStaff(staff);
                break;
            case 4:
                ReturnKey();
                return;
        }
    }
    public static void LeaderbordOptions(List<SeniorSportsMan> senior, List<JuniorSportsMan> junior, List<Staff> staff)
    {
        var choice = LeaderbordMenu();

        Menu();

        switch (choice)
        {
            case 1:
                Console.WriteLine("Seniors Leaderbord:");
                SeeSeniors(ApplicationService.GetSeniorsLeaderbord(senior));
                break;
            case 2:
                Console.WriteLine("Juniors Leaderbord:");
                SeeJuniors(ApplicationService.GetJuniorsLeaderbord(junior));
                break;
            case 3:
                Console.WriteLine("Staff members:");
                SeeStaff(ApplicationService.GetStaff(staff));
                break;
            case 4:
                ReturnKey();
                return;
        }
    }



    public static void DeleteSenior(List<SeniorSportsMan> senior)
    {
        var nameToDelete = GetStringUserInput(" Insert User name: ");

        var matching = senior.Where(s => s.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase)).ToList();


        if (matching.Count == 0)
        {
            Console.WriteLine($"\u001b[31m User {nameToDelete} not found!\u001b[37m");
        }
        else if (matching.Count == 1)
        {
            senior.Remove(matching.First());
            Console.WriteLine($"\u001b[32m User {nameToDelete} has been deleted! \u001b[0m");

        }
        else 
        {
            Console.WriteLine($"\u001b[31m There are multiple users with name: \u001b[37m {nameToDelete}");

            var indexToDelete = GetIntUserInput(" Insert User Index (0/1/2/3..) : ");

            if ( indexToDelete >= 0) 
            {
                matching.Remove(matching.First());
            }
        }
    }

    public static void DeleteJunior(List<JuniorSportsMan> juniors)
    {
        var nameToDelete = GetStringUserInput(" Insert User name: ");

        var matching = juniors.Where(s => s.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase)).ToList();

        if (matching.Count == 0)
        {
            Console.WriteLine($"\u001b[31m User {nameToDelete} not found!\u001b[37m");
        }
        else if (matching.Count == 1)
        {
            juniors.Remove(matching.First());
            Console.WriteLine($"\u001b[32m User {nameToDelete} has been deleted! \u001b[0m");

        }
        else 
        {
            Console.WriteLine($"\u001b[31m There are multiple users with name: \u001b[37m {nameToDelete}");

            var indexToDelete = GetIntUserInput(" Insert User Index (0/1/2/3..) : ");

            if ( indexToDelete >= 0) 
            {
                matching.Remove(matching.First());
            }
        }
    }
    public static void DeleteStaff(List<Staff> staff)
    {
        var nameToDelete = GetStringUserInput(" Insert User name: ");

        var matching = staff.Where(s => s.Name.Equals(nameToDelete, StringComparison.OrdinalIgnoreCase)).ToList();

        if (matching.Count == 0)
        {
            Console.WriteLine($"\u001b[31m User {nameToDelete} not found!\u001b[37m");
        }
        else if (matching.Count == 1)
        {
            staff.Remove(matching.First());
            Console.WriteLine($"\u001b[32m User {nameToDelete} has been deleted! \u001b[0m");

        }
        else 
        {
            Console.WriteLine($"\u001b[31m There are multiple users with name: \u001b[37m {nameToDelete}");

            var indexToDelete = GetIntUserInput(" Insert User Index (0/1/2/3..) : ");

            if ( indexToDelete >= 0) 
            {
                matching.Remove(matching.First());
            }
        }
    }


    public static void ListSenior(SeniorSportsMan senior)
    {

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($" {senior.Type} \u001b[31m{senior.Sport} | Place: {senior.Place}\u001b[37m | {senior.Name} | {senior.Country} | \u001b[32m{senior.WonBonus()}$\u001b[0m");
            Console.WriteLine("----------------------------------------------------");
    }

    public static void SeeSeniors(List<SeniorSportsMan> senior)
    {
        if (senior.Count > 0)
        {
            senior.ForEach(ListSenior);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("\u001b[31mSeniors List is empty!\u001b[37m");
        }
    }
     public static void ListJunior(JuniorSportsMan junior)
    {

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($" {junior.Type} \u001b[31m{junior.Sport} | Place: {junior.Place}\u001b[37m | {junior.Name} | {junior.Country} | \u001b[32m{junior.WonBonus()}$\u001b[0m");
        Console.WriteLine("----------------------------------------------------");
    }

    public static void SeeJuniors(List<JuniorSportsMan> junior)
    {
        if (junior.Count > 0)
        {
            junior.ForEach(ListJunior);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("\u001b[31mJuniors List is empty!\u001b[37m");
        }
    }
     public static void ListStaff(Staff staff)
    {

        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine($" {staff.Type} \u001b[31m{staff.Role} | Place: {staff.Name}\u001b[37m | {staff.Age} | {staff.Country} | \u001b[32m{staff.Salary()}$\u001b[0m");
        Console.WriteLine("----------------------------------------------------");
    }

    public static void SeeStaff(List<Staff> staff)
    {
        if (staff.Count > 0)
        {
            staff.ForEach(ListStaff);
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("u001b[31mStaff List is empty!\u001b[37m");
        }
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

        Menu();

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

        Menu();

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

        Menu();

        Console.WriteLine("\u001b[32m Staff member was added! \u001b[0m");

        return staff;
    }

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

    //public static MemberType GetMemberInput(string requestMessage)
    //{
    //    var input = GetStringUserInput(requestMessage);
    //    _ = Enum.TryParse<MemberType>(input, out var memberType);
    //    return memberType;
    //}

    public static void ReturnKey()
    {
        Console.Write("Press any key for Main Menu ... ");
        Console.ReadKey();
    }
}
