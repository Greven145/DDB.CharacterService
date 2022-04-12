namespace DDB.CharacterService.v3;

public record Actions(
    IReadOnlyList<Action> Race,
    IReadOnlyList<Action> Class,
    IReadOnlyList<Action> Background,
    IReadOnlyList<Action> Item,
    IReadOnlyList<Action> Feat
) : ISourceAggregator<Action>;