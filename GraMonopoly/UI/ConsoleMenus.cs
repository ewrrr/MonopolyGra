using Monopoly.Application;
using Monopoly.Domain;
using Monopoly.Infrastructure;

namespace Monopoly.UI;

public static class ConsoleMenus
{
    public static void Run()
    {
        Console.WriteLine("1 - Nowa gra | 2 - Wczytaj");

        var key = Console.ReadKey(true).Key;
        GameContext context;

        if (key == ConsoleKey.D2)
        {
            Console.Write("Nazwa zapisu: ");
            var name = Console.ReadLine();
            context = new GameSaver().Load(name);
        }
        else
        {
            context = new GameContext
            {
                Players = new()
                {
                    new Player { Name = "Gracz 1" },
                    new Player { Name = "Gracz 2" }
                },
                Board = BoardLoader.Load()
            };
        }

        new GameService(context).Start();
    }
}
