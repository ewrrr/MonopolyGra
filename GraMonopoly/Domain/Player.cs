namespace Monopoly.Domain;

public class Player : IPlayer
{
    public string Name { get; init; }
    public int Money { get; set; } = 1500;
    public int Position { get; set; }
    public int JailTurns { get; set; }

    public bool IsBankrupt => Money <= 0;

    public void Pay(int amount) => Money -= amount;
    public void Receive(int amount) => Money += amount;


}
