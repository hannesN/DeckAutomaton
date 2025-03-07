using System.Text.Json.Serialization;

namespace DeckAutomaton.Model;

public class Stack
{
    public required string Title { get; set; }
    public required int BoardId { get; set; }
    public required int DeletedAt { get; set; }
    public required long LastModified { get; set; }
    public List<Card> Cards { get; set; } = [];
    public required int Order { get; set; }
    public required int Id { get; set; }

    [JsonIgnore]
    public Board? Parent { get; set; }

}