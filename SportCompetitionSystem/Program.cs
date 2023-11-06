using SportCompetitionSystem.Domain;
using SportCompetitionSystem.Presentation;

namespace SportCompetitionSystem;

class Program
{
    static List<Staff> stafflist = new List<Staff>();
    static List<SeniorSportsMan> seniorslist = new List<SeniorSportsMan>();
    static List<JuniorSportsMan> juniorslist = new List<JuniorSportsMan>();

    static void Main(string[] args)
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
                Console.ReadKey();
        }
    }
}
