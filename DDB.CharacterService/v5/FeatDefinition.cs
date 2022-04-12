namespace DDB.CharacterService.v5;

public record FeatDefinition(
    int Id,
    int EntityTypeId,
    string Name,
    string Description,
    string Snippet,
    Activation Activation,
    object SourceId,
    int? SourcePageNumber,
    IReadOnlyList<object> CreatureRules,
    IReadOnlyList<object> Prerequisites,
    bool IsHomebrew,
    IReadOnlyList<Source> Sources,
    IReadOnlyList<object> SpellListIds
);