using Monopoly.Domain;

namespace Monopoly.Application;

public class PlayerStatusService
{
    private readonly GameContext _context;

    public PlayerStatusService(GameContext context)
    {
        _context = context;
    }

    public void Show(Player player)
    {
        Console.Clear();
        Console.WriteLine($"=== STAN GRACZA: {player.Name} ===\n");
        Console.WriteLine($"Saldo: {player.Money}");

        var properties = _context.Board
            .OfType<PropertyField>()
            .Where(p => p.Owner == player)
            .ToList();

        if (!properties.Any())
        {
            Console.WriteLine("Brak nieruchomości");
        }
        else
        {
            Console.WriteLine("Posiadłości:");
            foreach (var p in properties)
                Console.WriteLine($"- {p.Name}");
        }

        if (player.JailTurns > 0)
            Console.WriteLine($"W więzieniu ({player.JailTurns} tury)");

        Console.WriteLine("\nDowolny klawisz...");
        Console.ReadKey();
    }
}
