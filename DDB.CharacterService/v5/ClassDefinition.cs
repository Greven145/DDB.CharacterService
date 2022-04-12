namespace DDB.CharacterService.v5;

public record ClassDefinition(
    int Id,
    string Name,
    string Description,
    string EquipmentDescription,
    object ParentClassId,
    string AvatarUrl,
    string LargeAvatarUrl,
    string PortraitAvatarUrl,
    string MoreDetailsUrl,
    int? SpellCastingAbilityId,
    int? SourceId,
    int HitDice,
    IReadOnlyList<Source> Sources,
    IReadOnlyList<ClassFeature> ClassFeatures,
    WealthDice WealthDice,
    bool CanCastSpells,
    bool? KnowsAllSpells,
    int? SpellPrepareType,
    object SpellContainerName,
    int? SourcePageNumber,
    ClassDefinition SubclassDefinition,
    bool IsHomebrew,
    IReadOnlyList<int> PrimaryAbilities,
    SpellRules SpellRules,
    IReadOnlyList<Prerequisite> Prerequisites
);