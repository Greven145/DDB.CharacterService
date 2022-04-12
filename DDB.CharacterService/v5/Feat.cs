namespace DDB.CharacterService.v5;

public record Feat(
    int ComponentTypeId,
    int ComponentId,
    FeatDefinition Definition,
    int DefinitionId
);