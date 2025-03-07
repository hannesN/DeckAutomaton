using System.Text.Json;

namespace DeckAutomaton.Util;

public static class JsonExtension
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public static string ToJson<T>(this T obj)
    {
        return JsonSerializer.Serialize(obj, Options);
    }

    public static T? FromJson<T>(this string json)
    {
        return JsonSerializer.Deserialize<T>(json, options: Options);
    }
}