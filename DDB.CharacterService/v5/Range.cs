using System.Text.Json.Serialization;

namespace DDB.CharacterService.v5;

public record Range(
    string Origin,
    int? RangeValue,
    string AoeType,
    int? AoeValue,
    [property: JsonPropertyName("range")] int? RangeInFeet,
    object LongRange,
    int? AoeSize,
    bool HasAoeSpecialDescription,
    object MinimumRange
);