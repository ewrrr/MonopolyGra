using Monopoly.Domain;

namespace Monopoly.Application;

public class GameContext
{
    public List<Player> Players { get; set; }
    public List<BoardField> Board { get; set; }
    public int CurrentPlayerIndex { get; set; }

    public Player CurrentPlayer => Players[CurrentPlayerIndex];
}
