namespace DDB.CharacterService.v5;

public record Prerequisite(
    string Description,
    IReadOnlyList<PrerequisiteMapping> PrerequisiteMappings
);