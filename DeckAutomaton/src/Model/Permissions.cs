namespace DeckAutomaton.Model;

public class Permissions
{
    public required bool PERMISSION_READ { get; set; }
    public required bool PERMISSION_EDIT { get; set; }
    public required bool PERMISSION_MANAGE { get; set; }
    public required bool PERMISSION_SHARE { get; set; }
}