namespace DDB.CharacterService.v5;

public record Preferences(
    bool UseHomebrewContent,
    int ProgressionType,
    int EncumbranceType,
    bool IgnoreCoinWeight,
    int HitPointType,
    bool ShowUnarmedStrike,
    bool ShowScaledSpells,
    int PrimarySense,
    int PrimaryMovement,
    int PrivacyType,
    int SharingType,
    int AbilityScoreDisplayType,
    bool EnforceFeatRules,
    bool EnforceMulticlassRules,
    bool EnableOptionalClassFeatures,
    bool EnableOptionalOrigins,
    bool EnableDarkMode,
    bool EnableContainerCurrency
);