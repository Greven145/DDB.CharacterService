namespace DDB.CharacterService.v5;

public record ClassFeature(
    int Id,
    string Name,
    object Prerequisite,
    string Description,
    int RequiredLevel,
    int DisplayOrder,
    ClassFeatureDefinition Definition,
    LevelScale LevelScale
);