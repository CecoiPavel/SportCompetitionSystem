using SportCompetitionSystem.Domain.Abstractions.Interfaces;

namespace SportCompetitionSystem.Domain.Abstractions.Base;

public abstract class SportsMan : BaseUser, IWonBonus
{
    public int Place { get; set; }

    public SportsMan(
        string name,
        int age,
        string country,
        string sport,
        int place) : base(name, age, country, sport)
    {
        Place = place;
    }

    public override int RetirementStatus()
    { 
        return 0;
    }

    public abstract int WonBonus();
}
