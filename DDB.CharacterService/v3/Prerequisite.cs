namespace DDB.CharacterService.v3;

public record Prerequisite(
    string Description,
    IReadOnlyList<PrerequisiteMapping> PrerequisiteMappings
);