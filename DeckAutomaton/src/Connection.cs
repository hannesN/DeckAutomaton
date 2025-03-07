using System.Net.Http.Headers;
using System.Text;
using DeckAutomaton.Config;
using DeckAutomaton.Model;
using DeckAutomaton.Util;

namespace Deckautomation;

public class RestConnection

{
    private readonly Configuration mConfiguration;

    public RestConnection(Configuration configuration)
    {
        mConfiguration = configuration;
    }

    public async Task<Board[]> GetBoards()
    {
        return await Get<Board>("boards");
    }

    public async Task<Stack[]> GetStacks(Board board)
    {
        var result = await Get<Stack>($"boards/{board.Id}/stacks");
        foreach (var stack in result)
        {
            stack.Parent = board;
        }
        return result;
    }

    public async Task<Card[]> GetCards(Stack stack)
    {
        if (stack.Parent == null)
        {
            throw new ArgumentException("Stack must have a parent board");
        }
        var result= await Get<Card>($"boards/{stack.Parent.Id}/{stack.Id}/cards");
        foreach (var card in result)
        {
            card.Parent = stack;
        }
        return result;
    }

    private async Task<T[]> Get<T>(string url) 
    {
        using var client = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(Encoding.ASCII.GetBytes($"{mConfiguration.Username}:{mConfiguration.Password}")));
        var response = await client.GetAsync(mConfiguration.ApiUrl + url);
        response.EnsureSuccessStatusCode();
        var responseString = await response.Content.ReadAsStringAsync();

        Console.WriteLine(responseString);

        return responseString.FromJson<T[]>() ?? [];
    }

}