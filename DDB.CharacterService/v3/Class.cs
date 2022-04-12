namespace DDB.CharacterService.v3;

public record Class(
    int Id,
    int EntityTypeId,
    int Level,
    bool IsStartingClass,
    int HitDiceUsed,
    int DefinitionId,
    object SubclassDefinitionId,
    ClassDefinition Definition,
    ClassDefinition SubclassDefinition,
    IReadOnlyList<ClassFeature> ClassFeatures
);