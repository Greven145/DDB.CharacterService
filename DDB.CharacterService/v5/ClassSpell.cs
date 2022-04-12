namespace DDB.CharacterService.v5;

public record ClassSpell(
    int EntityTypeId,
    int CharacterClassId,
    IReadOnlyList<Spell> Spells
);