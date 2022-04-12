namespace DDB.CharacterService.v5;

public record DeathSaves(
    object FailCount,
    object SuccessCount,
    bool IsStabilized
);