namespace DDB.CharacterService.v3;

public record WeightSpeeds(
    Normal Normal,
    object Encumbered,
    object HeavilyEncumbered,
    object PushDragLift,
    object Override
);