namespace DDB.CharacterService.v3;

public record Option(
    int ComponentId,
    int ComponentTypeId,
    RaceOptionDefinition Definition
);