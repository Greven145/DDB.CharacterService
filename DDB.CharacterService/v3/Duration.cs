namespace DDB.CharacterService.v3;

public record Duration(
    int DurationInterval,
    string DurationUnit,
    string DurationType
);