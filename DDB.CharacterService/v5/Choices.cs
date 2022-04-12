namespace DDB.CharacterService.v5;

public record Choices(
    IReadOnlyList<Choice> Race,
    IReadOnlyList<Choice> Class,
    IReadOnlyList<Choice> Background,
    IReadOnlyList<Choice> Item,
    IReadOnlyList<Choice> Feat,
    IReadOnlyList<Choice> ChoiceDefinitions
) : ISourceAggregator<Choice>;