namespace DDB.CharacterService.v5;

public abstract record StatBase<T>(
    int Id,
    string Name,
    T Value
);

public record Stat(
    int Id,
    string Name,
    int Value
) : StatBase<int>(Id, Name, Value);

public record OptionalStat(
    int Id,
    string Name,
    int? Value
) : StatBase<int?>(Id, Name, Value);