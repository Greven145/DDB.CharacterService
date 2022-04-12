namespace DDB.CharacterService.v3;

public record OptionalStat(
    int Id,
    string Name,
    int? Value
) : StatBase<int?>(Id, Name, Value);