using System.Text.Json.Serialization;

namespace DeckAutomaton.Model;

public class Card
{
    public required int Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required int StackId { get; set; }
    public required string Type { get; set; }
    public required long LastModified { get; set; }
    public required long CreatedAt { get; set; }
    public List<Label> Labels { get; set; } = [];
    public List<UserAssignment>? AssignedUsers { get; set; }
    public List<string>? Attachments { get; set; }
    public int? AttachmentCount { get; set; }
    public required User Owner { get; set; }
    public required int Order { get; set; }
    public required bool Archived { get; set; }
    public DateTimeOffset? Done { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public required int DeletedAt { get; set; }
    public required int CommentsUnread { get; set; }
    public required int Overdue { get; set; }

    [JsonIgnore]
    public Stack? Parent { get; set; }
}
