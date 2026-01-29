using Monopoly.Application;

namespace Monopoly.Domain;

public class PropertyField : BoardField
{

    public int Price { get; }
    public int Rent { get; }
    public Player Owner { get; set; }

    public PropertyField(string name, int price, int rent)
        : base(name, FieldType.Property)
    {
        Price = price;
        Rent = rent;
    }

    public override void OnLand(GameContext context, Player player)
    {
        if (Owner == null)
        {
            Console.WriteLine($"Kup {Name} za {Price}? (T/N)");
            if (Console.ReadKey(true).Key == ConsoleKey.T && player.Money >= Price)
            {
                player.Pay(Price);
                Owner = player;
            }
        }
        else if (Owner != player)
        {
            Console.WriteLine($"Płacisz czynsz {Rent}");
            player.Pay(Rent);
            Owner.Receive(Rent);
        }
    }
}
