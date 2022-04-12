﻿namespace DDB.CharacterService.v5;

public record ClassFeatureDefinition(
    int Id,
    string DefinitionKey,
    int EntityTypeId,
    int DisplayOrder,
    string Name,
    string Description,
    string Snippet,
    object Activation,
    string MultiClassDescription,
    int RequiredLevel,
    bool IsSubClassFeature,
    IReadOnlyList<LimitedUse> LimitedUse,
    bool HideInBuilder,
    bool HideInSheet,
    int SourceId,
    int? SourcePageNumber,
    IReadOnlyList<object> CreatureRules,
    IReadOnlyList<LevelScale> LevelScales,
    IReadOnlyList<object> InfusionRules,
    IReadOnlyList<object> SpellListIds,
    int ClassId,
    int FeatureType,
    IReadOnlyList<Source> Sources,
    IReadOnlyList<object> AffectedFeatureDefinitionKeys,
    string EntityType,
    string EntityID
);