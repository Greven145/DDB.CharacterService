namespace DDB.CharacterService.v3;

public record WealthDice(
    int DiceCount,
    int DiceValue,
    int? DiceMultiplier,
    object FixedValue,
    string DiceString
);