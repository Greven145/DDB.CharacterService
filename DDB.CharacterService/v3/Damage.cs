namespace DDB.CharacterService.v3;

public record Damage(
    int DiceCount,
    int DiceValue,
    object DiceMultiplier,
    object FixedValue,
    string DiceString
);