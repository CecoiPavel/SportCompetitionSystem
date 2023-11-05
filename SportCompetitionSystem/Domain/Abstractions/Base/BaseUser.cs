using SportCompetitionSystem.Domain.Abstractions.Interfaces;

namespace SportCompetitionSystem.Domain.Abstractions.Base;

public abstract class BaseUser : IRetirement
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    public string Sport { get; set; }
    public MemberType Type { get; set; }

    public BaseUser()
    {

    }

    public BaseUser(string name, int age, string country, string sport)
    {
        Name = name;
        Age = age;
        Country = country;
        Sport = sport;
        
    }

    public int RetirementStatus();
}
