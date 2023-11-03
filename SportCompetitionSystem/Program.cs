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
                UI.Menu();

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        UI.LeaderbordOptions(seniorslist, juniorslist, stafflist);
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
                        UI.DeleteListOptions( seniorslist, juniorslist, stafflist);
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
}
