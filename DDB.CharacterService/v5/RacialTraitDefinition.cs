namespace DDB.CharacterService.v5;

public record RacialTraitDefinition(
    int Id,
    string DefinitionKey,
    int EntityTypeId,
    int DisplayOrder,
    string Name,
    string Description,
    string Snippet,
    bool HideInBuilder,
    bool HideInSheet,
    object Activation,
    int SourceId,
    int? SourcePageNumber,
    IReadOnlyList<object> CreatureRules,
    IReadOnlyList<object> SpellListIds,
    int FeatureType,
    IReadOnlyList<Source> Sources,
    IReadOnlyList<object> AffectedFeatureDefinitionKeys,
    bool IsCalledOut,
    string EntityType,
    string EntityID,
    int EntityRaceId,
    int EntityRaceTypeId,
    DisplayConfiguration DisplayConfiguration
);