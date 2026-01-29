using Monopoly.Domain;

namespace Monopoly.Infrastructure;

public static class BoardLoader
{
    public static List<BoardField> Load() => new()
    {
        new StartField(),                   
        new PropertyField("Warszawa", 60, 2),
        new CardField(),
        new PropertyField("Kraków", 60, 4),
        new TaxField("Podatek", 200),
        new PropertyField("Londyn", 200, 25),

        new PropertyField("Liverpool", 100, 6),
        new CardField(),
        new PropertyField("Tokio", 100, 6),
        new PropertyField("Osaka", 120, 8),

        new JailField(),                     
        new PropertyField("Berlin", 140, 10),
        new CardField(),
        new PropertyField("Hamburg", 140, 10),
        new PropertyField("Paryz", 160, 12),
        new PropertyField("Lyon", 200, 25),

        new PropertyField("Madryt", 180, 14),
        new CardField(),
        new PropertyField("Barcelona", 180, 14),
        new PropertyField("Rzym", 200, 16),

        new TaxField("Podatek", 100),     
        new PropertyField("Wenecja", 220, 18),
        new CardField(),
        new PropertyField("Moskwa", 220, 18),
        new PropertyField("Charków", 240, 20),
        new PropertyField("Lwów", 200, 25),

        new PropertyField("Kijów", 260, 22),
        new PropertyField("Chicago", 260, 22),
        new CardField(),
        new PropertyField("Nowy Jork", 280, 24),

        new GoToJailField(),                
        new PropertyField("California", 300, 26),
        new PropertyField("Ankara", 300, 26),
        new CardField(),
        new PropertyField("Stambuł", 320, 28),
        new PropertyField("Praga", 200, 25),

        new CardField(),
        new TaxField("Podatek", 100),
        
    };
}
