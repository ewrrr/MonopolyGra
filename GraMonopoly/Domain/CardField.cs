using Monopoly.Application;

namespace Monopoly.Domain;

public class CardField : BoardField
{
    private static readonly Random _rand = new();

    public CardField() : base("Szansa", FieldType.Card) { }

    public override void OnLand(GameContext context, Player player)
    {
        int value = _rand.Next(-200, 300);
        if (value >= 0)
        {
            Console.WriteLine($"Szansa: +{value}");
            player.Receive(value);
        }
        else
        {
            Console.WriteLine($"Szansa: {value}");
            player.Pay(Math.Abs(value));
        }
    }
}
