namespace SportCompetitionSystem.Domain.Services;

internal class ApplicationService
{
    public static void CenterText(string text)
    {
        int width = Console.WindowWidth;
        int height = Console.WindowHeight / 2;
        int leftPadding = (width - text.Length) / 2;

        for (int i = 0; i < height; i++)
        {
            Console.WriteLine();
        }

        Console.WriteLine(new string(' ', leftPadding) + text);
    }

    /* --------------------------Still not in use-------------------
    public static List<SeniorSportsMan> GetSeniorsLeaderbord(List<SeniorSportsMan> baselist)
    {
        return baselist.OrderBy(s => s.Place).ToList();
    }
    
    public static List<JuniorSportsMan> GetJuniorsLeaderbord(List<JuniorSportsMan> baselist)
    {
        return baselist.OrderBy(s => s.Place).ToList();
    }
    
    public static List<Staff> GetStaff(List<Staff> baselist)
    {
        return baselist.OrderBy(s => s.Name).ToList();
    }
    */
}
