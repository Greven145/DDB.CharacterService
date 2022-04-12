﻿namespace DDB.CharacterService.v5;

public record PlayerModifiers(
    object FixedValue,
    string Id,
    object EntityId,
    object EntityTypeId,
    string Type,
    string SubType,
    object Dice,
    string Restriction,
    int? StatId,
    bool RequiresAttunement,
    object Duration,
    string FriendlyTypeName,
    string FriendlySubtypeName,
    bool IsGranted,
    IReadOnlyList<object> BonusTypes,
    int? Value,
    object AvailableToMulticlass,
    int ModifierTypeId,
    int ModifierSubTypeId,
    int ComponentId,
    int ComponentTypeId,
    Die Die,
    int Count,
    object DurationUnit,
    bool UsePrimaryStat,
    AtHigherLevels AtHigherLevels,
    IReadOnlyList<Modifier> Race,
    IReadOnlyList<Modifier> Class,
    IReadOnlyList<Modifier> Background,
    IReadOnlyList<Modifier> Item,
    IReadOnlyList<Modifier> Feat
) : Modifier(
    FixedValue,
    Id,
    EntityId,
    EntityTypeId,
    Type,
    SubType,
    Dice,
    Restriction,
    StatId,
    RequiresAttunement,
    Duration,
    FriendlyTypeName,
    FriendlySubtypeName,
    IsGranted,
    BonusTypes,
    Value,
    AvailableToMulticlass,
    ModifierTypeId,
    ModifierSubTypeId,
    ComponentId,
    ComponentTypeId
), ISourceAggregator<Modifier>;