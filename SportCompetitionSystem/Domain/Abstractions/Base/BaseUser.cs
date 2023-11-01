namespace SportCompetitionSystem.Domain.Abstractions.Base;

public abstract class BaseUser
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Country { get; set; }
    public string Sport { get; set; }


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

}
