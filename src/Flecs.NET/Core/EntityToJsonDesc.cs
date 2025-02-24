using System;
using System.Runtime.CompilerServices;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

/// <summary>
///     A wrapper around ecs_entity_to_json_desc_t.
/// </summary>
public unsafe struct EntityToJsonDesc : IEquatable<EntityToJsonDesc>
{
    private ecs_entity_to_json_desc_t _desc;

    /// <summary>
    ///     Reference to desc.
    /// </summary>
    public ref ecs_entity_to_json_desc_t Desc => ref _desc;

    /// <summary>
    ///     Default serialization configuration.
    /// </summary>
    public static EntityToJsonDesc Default => new EntityToJsonDesc
    {
        Desc = new ecs_entity_to_json_desc_t()
        {
            serialize_doc =        false,
            serialize_full_paths = true,
            serialize_inherited =  false,
            serialize_values =     true,
            serialize_builtin =    false,
            serialize_type_info =  false,
            serialize_alerts =     false,
            serialize_refs =       0,
            serialize_matches =    false
        }
    };

    /// <summary>
    ///     Serialize entity id.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc EntityId(bool value = true)
    {
        Desc.serialize_entity_id = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize doc attributes.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc Doc(bool value = true)
    {
        Desc.serialize_doc = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize full paths for tags, components and pairs.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc FullPaths(bool value = true)
    {
        Desc.serialize_full_paths = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize base components.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc Inherited(bool value = true)
    {
        Desc.serialize_inherited = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize component values.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc Values(bool value = true)
    {
        Desc.serialize_values = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize builtin data as components (e.g. "name", "parent")
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc BuiltIn(bool value = true)
    {
        Desc.serialize_builtin = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize type info. (requires Values() to be set to true)
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc TypeInfo(bool value = true)
    {
        Desc.serialize_type_info = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize active alerts for entity.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc Alerts(bool value = true)
    {
        Desc.serialize_alerts = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize references (incoming edges) for relationship.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc Refs(ulong value)
    {
        Desc.serialize_refs = value;
        return ref this;
    }

    /// <summary>
    ///     Serialize which queries this entity matches with.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref EntityToJsonDesc Matches(bool value = true)
    {
        Desc.serialize_matches = value;
        return ref this;
    }

    /// <summary>
    ///     Checks if two <see cref="EntityToJsonDesc"/> instances are equal.
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool Equals(EntityToJsonDesc other)
    {
        return Desc == other.Desc;
    }

    /// <summary>
    ///     Checks if two <see cref="EntityToJsonDesc"/> instances are equal.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object? obj)
    {
        return obj is EntityToJsonDesc other && Equals(other);
    }

    /// <summary>
    ///     Returns the hash code for the <see cref="EntityToJsonDesc"/>.
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Desc.GetHashCode();
    }

    /// <summary>
    ///     Checks if two <see cref="EntityToJsonDesc"/> instances are equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator ==(EntityToJsonDesc left, EntityToJsonDesc right)
    {
        return left.Equals(right);
    }

    /// <summary>
    ///     Checks if two <see cref="EntityToJsonDesc"/> instances are not equal.
    /// </summary>
    /// <param name="left"></param>
    /// <param name="right"></param>
    /// <returns></returns>
    public static bool operator !=(EntityToJsonDesc left, EntityToJsonDesc right)
    {
        return !(left == right);
    }
}
