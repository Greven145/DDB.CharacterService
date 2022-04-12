namespace DDB.CharacterService.v5;

public record CharacterResponse(
    int Id,
    bool Success,
    string Message,
    Character Data,
    object Pagination
);