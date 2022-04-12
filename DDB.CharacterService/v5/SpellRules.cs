namespace DDB.CharacterService.v5;

public record SpellRules(
    int MultiClassSpellSlotDivisor,
    bool IsRitualSpellCaster,
    IReadOnlyList<int> LevelCantripsKnownMaxes,
    IReadOnlyList<int> LevelSpellKnownMaxes,
    IReadOnlyList<List<int>> LevelSpellSlots,
    int MultiClassSpellSlotRounding
);