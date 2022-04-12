namespace DDB.CharacterService.v5;

public record CharacterValue(
    int TypeId,
    string Value,
    object Notes,
    string ValueId,
    string ValueTypeId,
    object ContextId,
    object ContextTypeId
);