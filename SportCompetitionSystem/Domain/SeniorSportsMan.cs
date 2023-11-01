using SportCompetitionSystem.Domain.Abstractions.Base;
using SportCompetitionSystem.Domain.Abstractions.Interfaces;

namespace SportCompetitionSystem.Domain;

internal class SeniorSportsMan : SportsMan, IWonBonus, IRetirement, ILeaderbord
{
    public SeniorSportsMan(
        string name,
        int age,
        string country,
        string sport,
        int place) 
        : base(name, age, country, sport, place)
    {
    }

    public int WonBonus()
    {
        if (Place == 1)
        {
            return 10000;
        }
        if (Place == 2)
        {
            return 7000;
        }
        if (Place == 3)
        {
            return 5000;
        }
        if (Place >= 4 && Place <= 10)
        {
            return 1000;
        }
        else
        {
            return 0;
        }
    }

    public int RetirementStatus()
    {
        if (Age <= 24)
        {
            return Age + 16;
        }
        if (Age >= 24 && Age <= 30)
        {
            return Age + 10;
        }
        else
        {
            return Age + 5;
        }
    }

    public void Leaderbord(List<SeniorSportsMan> seniorslist)
    {
        seniorslist.Sort((p1, p2) => p1.Place.CompareTo(p2.Place));

        foreach (SeniorSportsMan senior in seniorslist)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($" Senior \u001b[31m{senior.Sport} --- {senior.Place}\u001b[37m --- {senior.Name} --- {senior.Country} --- \u001b[32m{senior.WonBonus()}$\u001b[0m");
            Console.WriteLine("----------------------------------------------------");
        }

    }

    public void AddSenior(List<SeniorSportsMan> seniorslist)
    {
        try
        {

            Console.WriteLine("  \u001b[31mInsert Senior details below:\u001b[37m");
            SeniorSportsMan seniors = new SeniorParticipant();
            Console.Write("    Name:");
            seniors.Name = Console.ReadLine();
            Console.Write("    Age: ");
            seniors.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("    Country: ");
            seniors.Country = Console.ReadLine();
            Console.Write("    Sport: ");
            seniors.Sport = Console.ReadLine();
            Console.Write("    Competition place: ");
            seniors.Place = Convert.ToInt32(Console.ReadLine());
            seniorslist.Add(seniors);
            Console.WriteLine("\u001b[32m Senior Participant was added! \u001b[0m");
        }
        catch (Exception)
        {
            Console.WriteLine("\u001b[31mInvalid characters!\u001b[37m");
        }
    }

    public void SeniorDisplay(List<SeniorSportsMan> seniorslist)
    {
        foreach (SeniorSportsMan s in seniorslist)
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine($" Status: Senior Name:\u001b[31m{s.Name} Place: {s.Place}\u001b[37m" +
                              $" Age: {s.Age} Country: {s.Country} Sport: {s.Sport} WinBonus: \u001b[32m{s.WonBonus()}$\u001b[0m");
            Console.WriteLine("---------------------------------------------------------------------");
        }
    }
}
