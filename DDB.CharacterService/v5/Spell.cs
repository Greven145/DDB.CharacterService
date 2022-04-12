namespace DDB.CharacterService.v5;

public record Spell(
    object OverrideSaveDc,
    LimitedUse LimitedUse,
    int Id,
    int EntityTypeId,
    SpellDefinition Definition,
    int DefinitionId,
    bool Prepared,
    bool CountsAsKnownSpell,
    bool UsesSpellSlot,
    object CastAtLevel,
    bool AlwaysPrepared,
    string Restriction,
    int? SpellCastingAbilityId,
    object DisplayAsAttack,
    object AdditionalDescription,
    bool CastOnlyAsRitual,
    object RitualCastingType,
    Range Range,
    Activation Activation,
    bool BaseLevelAtWill,
    object AtWillLimitedUseLevel,
    object IsSignatureSpell,
    int ComponentId,
    int ComponentTypeId,
    object SpellListId
);