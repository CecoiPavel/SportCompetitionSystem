using SportCompetitionSystem.Domain.Abstractions.Base;
using SportCompetitionSystem.Presentation;

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
    public static void Delete()
    {
        while (true)
        {
            try
            {
                UI.Delete();
                SelectItem();
            }
            catch (Exception)
            {
                UI.Exception();
            }
        }
    }

    public static List<SportsMan> GetLeaderBoard(List<SportsMan> sportsMen)
    {
        return sportsMen.OrderBy(s => s.Place).ToList();
    }

    private static void SelectItem()
    {
        int select = Convert.ToInt32(Console.ReadLine());
        switch (select)
        {
            case 1:
                break;

            case 2:
                break;

            case 3:
                break;

            case 4:
                UI.Exit();
                return;
        }
    }
}
