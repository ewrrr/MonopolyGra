using System.Text.Json;
using Monopoly.Application;

namespace Monopoly.Infrastructure;

public class GameSaver
{
    private static readonly JsonSerializerOptions Options = new()
    {
        WriteIndented = true,
        IncludeFields = true
    };

    public void Save(GameContext context)
    {
        Console.Write("\nNazwa zapisu: ");
        var name = Console.ReadLine();

        var json = JsonSerializer.Serialize(context, Options);
        File.WriteAllText($"{name}.json", json);

        Console.WriteLine("Zapisano poprawnie ✔");
    }

    public GameContext Load(string name)
    {
        var json = File.ReadAllText($"{name}.json");
        return JsonSerializer.Deserialize<GameContext>(json, Options)!;
    }
}
