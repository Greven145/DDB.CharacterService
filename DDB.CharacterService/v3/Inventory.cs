namespace DDB.CharacterService.v3;

public record Inventory(
    int Id,
    int EntityTypeId,
    InventoryDefinition Definition,
    int DefinitionId,
    int DefinitionTypeId,
    object DisplayAsAttack,
    int Quantity,
    bool IsAttuned,
    bool Equipped,
    int? EquippedEntityTypeId,
    int? EquippedEntityId,
    int ChargesUsed,
    LimitedUse LimitedUse,
    int ContainerEntityId,
    int ContainerEntityTypeId,
    string ContainerDefinitionKey,
    object Currency
);