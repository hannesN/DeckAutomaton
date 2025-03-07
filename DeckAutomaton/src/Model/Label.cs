namespace DeckAutomaton.Model;

public class Label
{
    public required string Title { get; set; }
    public required string Color { get; set; }
    public required int BoardId { get; set; }
    public required int? CardId { get; set; }
    public required int Id { get; set; }
}