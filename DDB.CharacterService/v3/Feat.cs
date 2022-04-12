namespace DDB.CharacterService.v3;

public record Feat(
    int ComponentTypeId,
    int ComponentId,
    FeatDefinition Definition,
    int DefinitionId
);