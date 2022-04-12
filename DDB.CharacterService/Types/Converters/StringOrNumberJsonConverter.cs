using System.Text.Json;
using System.Text.Json.Serialization;

namespace DDB.CharacterService.Types.Converters;

public class StringOrNumberJsonConverter : JsonConverter<StringOrNumber> {
    public override StringOrNumber? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
        if (reader.TryGetInt32(out var asNumber)) {
            return asNumber;
        }

        return reader.GetString();
    }

    public override void Write(Utf8JsonWriter writer, StringOrNumber value, JsonSerializerOptions options) {
        value.Switch(
            writer.WriteStringValue,
            writer.WriteNumberValue
        );
    }
}