using System.Text.Json.Serialization;
using DDB.CharacterService.Types.Converters;
using OneOf;

namespace DDB.CharacterService.Types;

[GenerateOneOf]
[JsonConverter(typeof(StringOrNumberJsonConverter))]
public partial class StringOrNumber : OneOfBase<string, int> {
}