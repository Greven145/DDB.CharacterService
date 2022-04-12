namespace DDB.CharacterService.v3;

public record Choices(
    IReadOnlyList<Choice> Race,
    IReadOnlyList<Choice> Class,
    IReadOnlyList<Choice> Background,
    IReadOnlyList<Choice> Item,
    IReadOnlyList<Choice> Feat,
    IReadOnlyList<Choice> ChoiceDefinitions
) : ISourceAggregator<Choice>;