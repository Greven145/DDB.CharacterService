using System.Text.Json.Serialization;

namespace DDB.CharacterService.v5;

public record ThemeColor(
    int ThemeColorId,
    [property: JsonPropertyName("themeColor")]
    string Color,
    string BackgroundColor,
    string Name,
    object RaceId,
    object SubRaceId,
    int ClassId,
    IReadOnlyList<string> Tags,
    string DecorationKey
);