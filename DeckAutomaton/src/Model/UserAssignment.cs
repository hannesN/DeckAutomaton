namespace DeckAutomaton.Model;

public class UserAssignment
{
    public int Id { get; set; }
    public required User Participant { get; set; }

    public int CardId { get; set; }

    public int Type { get; set; }
}