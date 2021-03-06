namespace DDB.CharacterService.v3;

public record BackgroundDefinition(
    int Id,
    int EntityTypeId,
    string Name,
    string Description,
    string Snippet,
    string ShortDescription,
    string SkillProficienciesDescription,
    string ToolProficienciesDescription,
    string LanguagesDescription,
    string EquipmentDescription,
    string FeatureName,
    string FeatureDescription,
    object AvatarUrl,
    object LargeAvatarUrl,
    string SuggestedCharacteristicsDescription,
    object SuggestedProficiencies,
    object SuggestedLanguages,
    object Organization,
    string ContractsDescription,
    string SpellsPreDescription,
    string SpellsPostDescription,
    IReadOnlyList<PersonalityTrait> PersonalityTraits,
    IReadOnlyList<PersonalityTrait> Ideals,
    IReadOnlyList<PersonalityTrait> Bonds,
    IReadOnlyList<PersonalityTrait> Flaws,
    bool IsHomebrew,
    IReadOnlyList<Source> Sources,
    IReadOnlyList<object> SpellListIds
);