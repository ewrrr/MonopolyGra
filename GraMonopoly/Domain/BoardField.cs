using Monopoly.Application;
using System.Text.Json.Serialization;

namespace Monopoly.Domain;

[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(StartField), "start")]
[JsonDerivedType(typeof(PropertyField), "property")]
[JsonDerivedType(typeof(TaxField), "tax")]
[JsonDerivedType(typeof(JailField), "jail")]
[JsonDerivedType(typeof(GoToJailField), "goToJail")]
[JsonDerivedType(typeof(CardField), "card")]
public abstract class BoardField
{
    public string Name { get; init; }
    public FieldType Type { get; init; }

    protected BoardField(string name, FieldType type)
    {
        Name = name;
        Type = type;
    }

    public abstract void OnLand(GameContext context, Player player);
}
