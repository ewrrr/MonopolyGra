namespace Monopoly.Domain;

public interface IPlayer
{
    string Name { get; }
    int Money { get; set; }
    int Position { get; set; }
    int JailTurns { get; set; }
    bool IsBankrupt { get; }

    void Pay(int amount);
    void Receive(int amount);
}
