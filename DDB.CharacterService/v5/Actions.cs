namespace DDB.CharacterService.v5;

public record Actions(
    IReadOnlyList<Action> Race,
    IReadOnlyList<Action> Class,
    IReadOnlyList<Action> Background,
    IReadOnlyList<Action> Item,
    IReadOnlyList<Action> Feat
) : ISourceAggregator<Action>;