﻿// Find/Iterable/T6.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Invoker.cs
using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Invoker
{
    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, Ecs.FindRefCallback<T0, T1, T2, T3, T4, T5> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, Ecs.FindEntityRefCallback<T0, T1, T2, T3, T4, T5> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, Ecs.FindIterRefCallback<T0, T1, T2, T3, T4, T5> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, bool> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, bool> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, bool> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, Ecs.FindPointerCallback<T0, T1, T2, T3, T4, T5> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, Ecs.FindEntityPointerCallback<T0, T1, T2, T3, T4, T5> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, Ecs.FindIterPointerCallback<T0, T1, T2, T3, T4, T5> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, delegate*<T0*, T1*, T2*, T3*, T4*, T5*, bool> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, bool> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Find callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam>
    public static Entity Find<T, T0, T1, T2, T3, T4, T5>(ref T iterable, delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, bool> callback)
        where T : unmanaged, IIterableBase
    {
        Entity result = default;

        ecs_iter_t iter = iterable.GetIter();
        while (result == 0 && iterable.GetNext(&iter))
            result = Find(&iter, callback);
            
        if (result != 0)
            ecs_iter_fini(&iter);
        
        return result;
    }
}