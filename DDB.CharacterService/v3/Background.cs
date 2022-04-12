namespace DDB.CharacterService.v3;

public record Background(
    bool HasCustomBackground,
    BackgroundDefinition Definition,
    object DefinitionId,
    CustomBackground CustomBackground
);