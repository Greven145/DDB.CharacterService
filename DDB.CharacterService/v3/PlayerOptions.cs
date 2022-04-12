namespace DDB.CharacterService.v3;

public record PlayerOptions(
    IReadOnlyList<Option> Race,
    IReadOnlyList<Option> Class,
    IReadOnlyList<Option> Background,
    IReadOnlyList<Option> Item,
    IReadOnlyList<Option> Feat
) : ISourceAggregator<Option>;