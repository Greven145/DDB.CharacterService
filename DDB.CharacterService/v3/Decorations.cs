namespace DDB.CharacterService.v3;

public record Decorations(
    string AvatarUrl,
    string FrameAvatarUrl,
    string BackdropAvatarUrl,
    string SmallBackdropAvatarUrl,
    string LargeBackdropAvatarUrl,
    string ThumbnailBackdropAvatarUrl,
    DefaultBackdrop DefaultBackdrop,
    int? AvatarId,
    object PortraitDecorationKey,
    string FrameAvatarDecorationKey,
    int? FrameAvatarId,
    string BackdropAvatarDecorationKey,
    int? BackdropAvatarId,
    string SmallBackdropAvatarDecorationKey,
    int? SmallBackdropAvatarId,
    string LargeBackdropAvatarDecorationKey,
    int? LargeBackdropAvatarId,
    string ThumbnailBackdropAvatarDecorationKey,
    int? ThumbnailBackdropAvatarId,
    ThemeColor ThemeColor
);