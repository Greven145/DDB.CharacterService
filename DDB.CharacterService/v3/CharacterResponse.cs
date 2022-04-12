namespace DDB.CharacterService.v3;

public record CharacterResponse(
    int Id,
    bool Success,
    string Message,
    Character Data,
    object Pagination
);