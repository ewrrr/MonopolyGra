using Monopoly.Application;

namespace Monopoly.Domain;

public class StartField : BoardField
{
    public StartField() : base("Start", FieldType.Start) { }

    public override void OnLand(GameContext context, Player player)
    {
        Console.WriteLine("Przechodzisz przez START +200");
        player.Receive(200);
    }
}
