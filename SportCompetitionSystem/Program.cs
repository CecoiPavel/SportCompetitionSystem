using SportCompetitionSystem.Domain;
using SportCompetitionSystem.Domain.Abstractions.Base;
using SportCompetitionSystem.Domain.Services;
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
                Console.WindowWidth = 150;
                Console.WindowHeight = 30;
                Console.Clear();
                UI.Menu();

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        var sportsMen = GetSportsMen();
                        var orderedSportsMen = ApplicationService.GetLeaderBoard(sportsMen);
                        UI.LeaderBoard(orderedSportsMen);
                        break;
                    case 1:
                        var senior = UI.CreateSenior();
                        seniorslist.Add(senior);
                        break;

                    case 2:
                        var junior = UI.CreateJunior();
                        juniorslist.Add(junior);
                        break;

                    case 3:
                        var staff = UI.CreateStaff();
                        stafflist.Add(staff);
                        break;

                    case 4:
                        //Math.Delete();
                        break;
                        
                    case 5 :
                        UI.Exit();
                        return;
                }
            }
            catch(Exception) 
            {
                UI.Exception();
            }
                Console.ReadKey();
        }

    }

    static List<SportsMan> GetSportsMen()
    {
        var result = new List<SportsMan>();

        result.AddRange(seniorslist);
        result.AddRange(juniorslist);

        return result;
    }
}
