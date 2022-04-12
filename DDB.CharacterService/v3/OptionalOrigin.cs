namespace DDB.CharacterService.v3;

public record OptionalOrigin(
    int RacialTraitId,
    int AffectedRacialTraitId,
    string RacialTraitDefinitionKey,
    string AffectedRacialTraitDefinitionKey
);