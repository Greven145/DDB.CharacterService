namespace DDB.CharacterService.v5;

public record HigherLevelDefinition(
    int? Level,
    int TypeId,
    object Dice,
    int Value,
    string Details
);