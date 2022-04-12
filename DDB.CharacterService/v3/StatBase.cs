namespace DDB.CharacterService.v3;

public abstract record StatBase<T>(
    int Id,
    string Name,
    T Value
);