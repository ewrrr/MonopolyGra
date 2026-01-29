using Monopoly.Application;

namespace Monopoly.Domain;

public class GoToJailField : BoardField
{
    public GoToJailField() : base("Idź do więzienia", FieldType.GoToJail) { }

    public override void OnLand(GameContext context, Player player)
    {
        player.Position = context.Board.FindIndex(f => f.Type == FieldType.Jail);
        player.JailTurns = 2;
        Console.WriteLine("Idziesz do więzienia na 2 tury!");
    }
}
