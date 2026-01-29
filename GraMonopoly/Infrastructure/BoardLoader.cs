using Monopoly.Domain;

namespace Monopoly.Infrastructure;

public static class BoardLoader
{
    public static List<BoardField> Load() => new()
    {
        new StartField(),                    // 0
        new PropertyField("Mediterranean Ave", 60, 2),
        new CardField(),
        new PropertyField("Baltic Ave", 60, 4),
        new TaxField("Income Tax", 200),
        new PropertyField("Reading Railroad", 200, 25),

        new PropertyField("Oriental Ave", 100, 6),
        new CardField(),
        new PropertyField("Vermont Ave", 100, 6),
        new PropertyField("Connecticut Ave", 120, 8),

        new JailField(),                     // 10
        new PropertyField("St. Charles Place", 140, 10),
        new CardField(),
        new PropertyField("States Ave", 140, 10),
        new PropertyField("Virginia Ave", 160, 12),
        new PropertyField("Pennsylvania RR", 200, 25),

        new PropertyField("St. James Place", 180, 14),
        new CardField(),
        new PropertyField("Tennessee Ave", 180, 14),
        new PropertyField("New York Ave", 200, 16),

        new TaxField("Free Parking", 0),     // 20
        new PropertyField("Kentucky Ave", 220, 18),
        new CardField(),
        new PropertyField("Indiana Ave", 220, 18),
        new PropertyField("Illinois Ave", 240, 20),
        new PropertyField("B&O Railroad", 200, 25),

        new PropertyField("Atlantic Ave", 260, 22),
        new PropertyField("Ventnor Ave", 260, 22),
        new CardField(),
        new PropertyField("Marvin Gardens", 280, 24),

        new GoToJailField(),                 // 30
        new PropertyField("Pacific Ave", 300, 26),
        new PropertyField("North Carolina Ave", 300, 26),
        new CardField(),
        new PropertyField("Pennsylvania Ave", 320, 28),
        new PropertyField("Short Line", 200, 25),

        new CardField(),
        new PropertyField("Park Place", 350, 35),
        new TaxField("Luxury Tax", 100),
        new PropertyField("Boardwalk", 400, 50)
    };
}
