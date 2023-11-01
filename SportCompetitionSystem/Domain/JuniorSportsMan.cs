using SportCompetitionSystem.Domain.Abstractions.Base;
using SportCompetitionSystem.Domain.Abstractions.Interfaces;

namespace SportCompetitionSystem.Domain;

internal class JuniorSportsMan : SportsMan, IPromotion
{
    public JuniorSportsMan(
        string name,
        int age,
        string country,
        string sport,
        int place) : base(name, age, country, sport, place)
    {
    }

    public override int WonBonus()
    {
        if (Place == 1)
        {
            return 3000;
        }
        if (Place == 2)
        {
            return 2000;
        }
        if (Place == 3)
        {
            return 1000;
        }
        if (Place >= 4 && Place <= 10)
        {
            return 200;
        }
        else
        {
            return 0;
        }
    }

    public bool IsPromoting()
    {
        if (Place <= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void Leaderbord(List<BaseUser> allparticipants)
    {
        allparticipants.Sort((p1, p2) => p1.Place.CompareTo(p2.Place));

        foreach (JuniorSportsMan junior in juniorslist)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($" Junior \u001b[31m{junior.Sport} --- {junior.Place}\u001b[37m --- {junior.Name} --- {junior.Country} --- \u001b[32m{junior.WonBonus()}$\u001b[0m");
            Console.WriteLine("----------------------------------------------------");
        }

        Console.ReadKey();
    }

    public override int RetirementStatus()
    {
        return 0;
    }
}
