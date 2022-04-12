namespace DDB.CharacterService.v5;

public record Dice(
    int? DiceCount,
    int? DiceValue,
    object DiceMultiplier,
    object FixedValue,
    string DiceString
);