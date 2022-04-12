namespace DDB.CharacterService.v5;

public record Background(
    bool HasCustomBackground,
    BackgroundDefinition Definition,
    object DefinitionId,
    CustomBackground CustomBackground
);