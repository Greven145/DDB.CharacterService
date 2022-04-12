namespace DDB.CharacterService.v5;

public record AtHigherLevels(
    string ScaleType,
    IReadOnlyList<object> HigherLevelDefinitions,
    IReadOnlyList<object> AdditionalAttacks,
    IReadOnlyList<object> AdditionalTargets,
    IReadOnlyList<object> AreaOfEffect,
    IReadOnlyList<object> Duration,
    IReadOnlyList<object> Creatures,
    IReadOnlyList<object> Special,
    IReadOnlyList<object> Points,
    IReadOnlyList<object> Range
);