using Monopoly.Application;

namespace Monopoly.Domain;

public class JailField : BoardField
{
    public JailField() : base("Więzienie", FieldType.Jail) { }

    public override void OnLand(GameContext context, Player player)
    {
        Console.WriteLine("Odwiedzasz więzienie");
    }
}
