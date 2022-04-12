namespace DDB.CharacterService.v3;

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