namespace DDB.CharacterService.v3;

public record CampaignCharacter(
    int UserId,
    string Username,
    int CharacterId,
    string CharacterName,
    string CharacterUrl,
    string AvatarUrl,
    int PrivacyType,
    object CampaignId,
    bool IsAssigned
);