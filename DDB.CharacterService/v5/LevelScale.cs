namespace DDB.CharacterService.v5;

public record LevelScale(
    int Id,
    int Level,
    string Description,
    Dice Dice,
    int? FixedValue
);