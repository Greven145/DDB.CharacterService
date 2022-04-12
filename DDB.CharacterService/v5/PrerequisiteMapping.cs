namespace DDB.CharacterService.v5;

public record PrerequisiteMapping(
    int Id,
    int EntityId,
    int EntityTypeId,
    string Type,
    string SubType,
    int Value,
    string FriendlyTypeName,
    string FriendlySubTypeName
);