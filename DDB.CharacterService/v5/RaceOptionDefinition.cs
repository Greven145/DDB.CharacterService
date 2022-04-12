namespace DDB.CharacterService.v5;

public record RaceOptionDefinition(
    int Id,
    int EntityTypeId,
    string Name,
    string Description,
    string Snippet,
    object Activation,
    object SourceId,
    int? SourcePageNumber,
    IReadOnlyList<object> CreatureRules,
    IReadOnlyList<object> SpellListIds
);