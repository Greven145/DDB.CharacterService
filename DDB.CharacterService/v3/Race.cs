namespace DDB.CharacterService.v3;

public record Race(
    bool IsSubRace,
    string BaseRaceName,
    int EntityRaceId,
    int EntityRaceTypeId,
    string FullName,
    int BaseRaceId,
    int BaseRaceTypeId,
    string Description,
    string AvatarUrl,
    string LargeAvatarUrl,
    string PortraitAvatarUrl,
    string MoreDetailsUrl,
    bool IsHomebrew,
    IReadOnlyList<object> SourceIds,
    IReadOnlyList<int> GroupIds,
    int Type,
    object SupportsSubrace,
    string SubRaceShortName,
    string BaseName,
    IReadOnlyList<RacialTrait> RacialTraits,
    WeightSpeeds WeightSpeeds,
    IReadOnlyList<object> FeatIds,
    object Size,
    int SizeId,
    IReadOnlyList<Source> Sources
);