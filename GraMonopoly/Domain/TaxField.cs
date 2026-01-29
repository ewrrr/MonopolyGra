using Monopoly.Application;

namespace Monopoly.Domain;

public class TaxField : BoardField
{
    public int Tax { get; }

    public TaxField(string name, int tax)
        : base(name, FieldType.Tax)
    {
        Tax = tax;
    }

    public override void OnLand(GameContext context, Player player)
    {
        Console.WriteLine($"Podatek: {Tax}");
        player.Pay(Tax);
    }
}
