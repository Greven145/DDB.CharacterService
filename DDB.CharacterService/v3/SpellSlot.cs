namespace DDB.CharacterService.v3;

public record SpellSlot(
    int Level,
    int Used,
    int Available
);