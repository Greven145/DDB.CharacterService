namespace DDB.CharacterService.v3;

public record Dice(
    int? DiceCount,
    int? DiceValue,
    object DiceMultiplier,
    object FixedValue,
    string DiceString
);