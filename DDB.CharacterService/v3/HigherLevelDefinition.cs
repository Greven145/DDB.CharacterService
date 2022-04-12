namespace DDB.CharacterService.v3;

public record HigherLevelDefinition(
    int? Level,
    int TypeId,
    object Dice,
    int Value,
    string Details
);