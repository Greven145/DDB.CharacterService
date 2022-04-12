namespace DDB.CharacterService.v5;

public record Condition(
    int Type,
    int ConditionId,
    int ConditionDuration,
    string DurationUnit,
    string Exception
);