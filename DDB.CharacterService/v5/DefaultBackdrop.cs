// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace DDB.CharacterService.v5;

public record DefaultBackdrop(
    string BackdropAvatarUrl,
    string SmallBackdropAvatarUrl,
    string LargeBackdropAvatarUrl,
    string ThumbnailBackdropAvatarUrl
);