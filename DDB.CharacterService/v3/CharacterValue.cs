namespace DDB.CharacterService.v3;

public record CharacterValue(
    int TypeId,
    string Value,
    object Notes,
    string ValueId,
    string ValueTypeId,
    object ContextId,
    object ContextTypeId
);