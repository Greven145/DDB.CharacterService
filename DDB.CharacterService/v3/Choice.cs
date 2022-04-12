namespace DDB.CharacterService.v3;

public record Choice(
    int ComponentId,
    int ComponentTypeId,
    string Id,
    string ParentChoiceId,
    int Type,
    int? SubType,
    int? OptionValue,
    string Label,
    bool IsOptional,
    bool IsInfinite,
    IReadOnlyList<object> DefaultSubtypes,
    object DisplayOrder,
    IReadOnlyList<ChoiceOption> Options,
    IReadOnlyList<object> OptionIds
);