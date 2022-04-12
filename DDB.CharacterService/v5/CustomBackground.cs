namespace DDB.CharacterService.v5;

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