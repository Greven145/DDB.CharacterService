namespace DDB.CharacterService.v5;

public interface ISourceAggregator<T> {
    IReadOnlyList<T> Background { get; init; }
    IReadOnlyList<T> Class { get; init; }
    IReadOnlyList<T> Feat { get; init; }
    IReadOnlyList<T> Item { get; init; }
    IReadOnlyList<T> Race { get; init; }
}