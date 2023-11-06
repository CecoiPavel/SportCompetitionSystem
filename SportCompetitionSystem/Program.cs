using SportCompetitionSystem.Domain;
using SportCompetitionSystem.Presentation;

namespace SportCompetitionSystem;

class Program
{
    static readonly List<Staff> stafflist = new();
    static readonly List<SeniorSportsMan> seniorslist = new();
    static readonly List<JuniorSportsMan> juniorslist = new();

    static void Main()
    {
        while (true)
        {
            try
            {
                UI.Interface(seniorslist, juniorslist, stafflist);
            }
            catch(Exception) 
            {
                UI.Exception();
            }

            UI.ReturnKey();
        }
    }
}
