namespace DDB.CharacterService.v3;

public record ClassSpell(
    int EntityTypeId,
    int CharacterClassId,
    IReadOnlyList<Spell> Spells
);