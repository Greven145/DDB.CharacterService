namespace DDB.CharacterService.v5;

public record ClassOptionDefinition(
    int Id,
    int EntityTypeId,
    string Name,
    string Description,
    string Snippet,
    object Activation,
    int SourceId,
    int? SourcePageNumber,
    IReadOnlyList<object> CreatureRules,
    IReadOnlyList<object> SpellListIds
);