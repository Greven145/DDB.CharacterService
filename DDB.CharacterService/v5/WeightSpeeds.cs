namespace DDB.CharacterService.v5;

public record WeightSpeeds(
    Normal Normal,
    object Encumbered,
    object HeavilyEncumbered,
    object PushDragLift,
    object Override
);