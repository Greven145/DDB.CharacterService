namespace DDB.CharacterService.v5;

public record Damage(
    int DiceCount,
    int DiceValue,
    object DiceMultiplier,
    object FixedValue,
    string DiceString
);