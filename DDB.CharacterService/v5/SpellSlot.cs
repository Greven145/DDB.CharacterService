namespace DDB.CharacterService.v5;

public record SpellSlot(
    int Level,
    int Used,
    int Available
);