namespace DDB.CharacterService.v3;

public record CustomBackground(
    int Id,
    int EntityTypeId,
    string Name,
    object Description,
    BackgroundDefinition FeaturesBackground,
    BackgroundDefinition CharacteristicsBackground,
    object FeaturesBackgroundDefinitionId,
    object CharacteristicsBackgroundDefinitionId,
    int? BackgroundType
);