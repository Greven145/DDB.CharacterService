namespace DDB.CharacterService.v3;

public record Modifier(
    object FixedValue,
    string Id,
    object EntityId,
    object EntityTypeId,
    string Type,
    string SubType,
    object Dice,
    string Restriction,
    int? StatId,
    bool RequiresAttunement,
    object Duration,
    string FriendlyTypeName,
    string FriendlySubtypeName,
    bool IsGranted,
    IReadOnlyList<object> BonusTypes,
    int? Value,
    object AvailableToMulticlass,
    int ModifierTypeId,
    int ModifierSubTypeId,
    int ComponentId,
    int ComponentTypeId
);