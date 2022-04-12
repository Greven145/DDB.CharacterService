namespace DDB.CharacterService.v5;

public record OptionalOrigin(
    int RacialTraitId,
    int AffectedRacialTraitId,
    string RacialTraitDefinitionKey,
    string AffectedRacialTraitDefinitionKey
);