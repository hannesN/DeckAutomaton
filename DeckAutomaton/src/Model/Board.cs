using System.Text.Json.Serialization;

namespace DeckAutomaton.Model;

public class Board
{
    public  string Title { get; set; }
    public  User Owner { get; set; }
    public  string Color { get; set; }
    public  bool Archived { get; set; }
    public  List<Label> Labels { get; set; }
    public  List<AclRule> Acl { get; set; }
    public  Permissions Permissions { get; set; }
    public  List<User> Users { get; set; }
    public  int Shared { get; set; }
    public  int DeletedAt { get; set; }
    public  int Id { get; set; }
    public  long LastModified { get; set; }
    public  List<Settings> Settings { get; set; } = [];
}