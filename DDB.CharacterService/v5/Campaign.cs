namespace DDB.CharacterService.v5;

public record Campaign(
    int Id,
    string Name,
    string Description,
    string Link,
    string PublicNotes,
    int DmUserId,
    string DmUsername,
    IReadOnlyList<Character> Characters
);