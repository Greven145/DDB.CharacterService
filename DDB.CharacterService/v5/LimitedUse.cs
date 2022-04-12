using DDB.CharacterService.Types;

namespace DDB.CharacterService.v5;

public record LimitedUse(
    int MaxUses,
    int NumberUsed,
    StringOrNumber ResetType,
    string ResetTypeDescription,
    object Level,
    int Uses,
    object Name,
    object StatModifierUsesId,
    object MinNumberConsumed,
    int MaxNumberConsumed,
    object Operator,
    bool UseProficiencyBonus,
    object ProficiencyBonusOperator,
    object ResetDice
);