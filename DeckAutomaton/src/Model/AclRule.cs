namespace DeckAutomaton.Model;

public class AclRule
{
    public required int Id { get; set; }
    public required int Type { get; set; }
    public required int BoardId { get; set; }
    public required User Participant { get; set; }
    public required bool PermissionEdit { get; set; }
    public required bool PermissionShare { get; set; }
    public required bool PermissionManage { get; set; }
    public required bool Owner { get; set; }
}