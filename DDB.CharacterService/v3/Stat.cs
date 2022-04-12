namespace DDB.CharacterService.v3;

public record Stat(
    int Id,
    string Name,
    int Value
) : StatBase<int>(Id, Name, Value);