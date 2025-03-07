using System.Net.Http.Headers;
using System.Text;
using Deckautomation;
using DeckAutomaton.Config;
using DeckAutomaton.Model;
using DeckAutomaton.Util;

public class Program
{
    static async Task Main(string[] args)
    {
        RestConnection connection = new(Configuration.Load("application.config.json"));

        var boards = await connection.GetBoards();
        Console.WriteLine($"Number of Bords found: {boards.Length}. Names: '{string.Join("', '", boards.Select(b => b.Title))}'");

        var testBoard = boards.Where(b=>b.Title.Trim().Equals("Test-Board")).First();
        var stacks = await connection.GetStacks(testBoard);
        Console.WriteLine($"Number of Stacks found: {stacks.Length}. Titles: {string.Join(", ", stacks.Select(s => s.Title))}");

        stacks[2].Cards.ForEach(c => Console.WriteLine($"Card: {c.Title}"));

    }
}