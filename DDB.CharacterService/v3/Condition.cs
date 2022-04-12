namespace DDB.CharacterService.v3;

public record Condition(
    int Type,
    int ConditionId,
    int ConditionDuration,
    string DurationUnit,
    string Exception
);