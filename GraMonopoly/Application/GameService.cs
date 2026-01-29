using Monopoly.Domain;
using Monopoly.Infrastructure;

namespace Monopoly.Application;

public class GameService : IGameService
{
    private readonly GameContext _context;
    private readonly GameSaver _saver;
    private readonly Random _dice = new();
    private readonly PlayerStatusService _statusService;


    public GameService(GameContext context)
    {
        _context = context;
        _saver = new GameSaver();
        _statusService = new PlayerStatusService(context);
    }

    public void Start()
    {
        while (_context.Players.Count(p => !p.IsBankrupt) > 1)
        {
            NextTurn();
        }

        var winner = _context.Players.First(p => !p.IsBankrupt);

        Console.Clear();
        Console.WriteLine($"🏆 WYGRYWA: {winner.Name} z saldem {winner.Money} 💰");
        Console.ReadKey();
    }


    public void NextTurn()
    {
        var p = _context.CurrentPlayer;

        if (p.IsBankrupt)
        {
            NextPlayer();
            return;
        }

        Console.Clear();
        Console.WriteLine("=== MONOPOLY ===\n");

        foreach (var player in _context.Players)
        {
            Console.WriteLine($"{player.Name,-10} | 💰 {player.Money} | 📍 {player.Position}");
        }

        Console.WriteLine($"\nTURA: {p.Name}");

        Console.WriteLine("ENTER - rzut kostką | Z - zapisz | B - bankrut |  S - stan gracza");

        if (p.JailTurns > 0)
        {
            p.JailTurns--;
            Console.WriteLine("🚔 W więzieniu...");
            Console.ReadKey();
            NextPlayer();
            return;
        }

        var key = Console.ReadKey(true).Key;
        if (key == ConsoleKey.S)
        {
            _statusService.Show(p);
            return;
        }

        if (key == ConsoleKey.B)
        {
            p.Money = 0;
            Console.WriteLine($"{p.Name} ogłasza BANKRUCTWO!");
            Console.ReadKey();
            return;
        }

        if (key == ConsoleKey.Z)
        {
            _saver.Save(_context);
            return;
        }


        RollAndMove(p);
    }

    private void RollAndMove(Player p)
    {
        int roll = _dice.Next(1, 7);
        Console.WriteLine($"🎲 Wyrzucono: {roll}");

        int oldPos = p.Position;
        p.Position = (p.Position + roll) % _context.Board.Count;

        if (p.Position < oldPos)
            p.Receive(200);

        _context.Board[p.Position].OnLand(_context, p);

        Console.ReadKey();
        NextPlayer();
    }



    private void NextPlayer()
        => _context.CurrentPlayerIndex = (_context.CurrentPlayerIndex + 1) % _context.Players.Count;
}
