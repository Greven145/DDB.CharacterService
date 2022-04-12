namespace DDB.CharacterService.v3;

public record LevelScale(
    int Id,
    int Level,
    string Description,
    Dice Dice,
    int? FixedValue
);