namespace DeckAutomaton.Model;

public class User
{
    public required string PrimaryKey { get; set; }
    public required string Uid { get; set; }
    public required string DisplayName { get; set; }
    public int Type { get; set; }
}