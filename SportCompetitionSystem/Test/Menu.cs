namespace SportCompetitionSystem.Test;

public class Menu
{
    public int Id { get; set; }
    public Action HeaderMenu { get; set; }
    public List<Option> Options { get; set; }
    public int RootId { get; set; }
}
