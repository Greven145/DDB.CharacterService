namespace DDB.CharacterService.v5;

public record Option(
    int ComponentId,
    int ComponentTypeId,
    RaceOptionDefinition Definition
);