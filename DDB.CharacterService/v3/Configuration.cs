namespace DDB.CharacterService.v3;

public record Configuration(
    int? StartingEquipmentType,
    int AbilityScoreType,
    bool ShowHelpText
);