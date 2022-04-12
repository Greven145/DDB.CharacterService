namespace DDB.CharacterService.v3;

public record DeathSaves(
    object FailCount,
    object SuccessCount,
    bool IsStabilized
);