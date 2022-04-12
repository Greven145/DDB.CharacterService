namespace DDB.CharacterService.v5;

public record WealthDice(
    int DiceCount,
    int DiceValue,
    int? DiceMultiplier,
    object FixedValue,
    string DiceString
);