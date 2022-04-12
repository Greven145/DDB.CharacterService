namespace DDB.CharacterService.v3;

public record GrantedModifier(
    int? FixedValue,
    string Id,
    object EntityId,
    object EntityTypeId,
    string Type,
    string SubType,
    object Dice,
    string Restriction,
    object StatId,
    bool RequiresAttunement,
    object Duration,
    string FriendlyTypeName,
    string FriendlySubtypeName,
    bool IsGranted,
    IReadOnlyList<object> BonusTypes,
    int? Value,
    bool AvailableToMulticlass,
    int ModifierTypeId,
    int ModifierSubTypeId,
    int ComponentId,
    int ComponentTypeId
);