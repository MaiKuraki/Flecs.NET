﻿// Each/Iterable/T4.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Invoker.cs
using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Invoker
{
    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, Ecs.EachRefCallback<T0, T1, T2, T3> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, Ecs.EachEntityRefCallback<T0, T1, T2, T3> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, Ecs.EachIterRefCallback<T0, T1, T2, T3> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, delegate*<ref T0, ref T1, ref T2, ref T3, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, delegate*<Entity, ref T0, ref T1, ref T2, ref T3, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, Ecs.EachPointerCallback<T0, T1, T2, T3> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, Ecs.EachEntityPointerCallback<T0, T1, T2, T3> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, Ecs.EachIterPointerCallback<T0, T1, T2, T3> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, delegate*<T0*, T1*, T2*, T3*, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, delegate*<Entity, T0*, T1*, T2*, T3*, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Each callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam>
    public static void Each<T, T0, T1, T2, T3>(ref T iterable, delegate*<Iter, int, T0*, T1*, T2*, T3*, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Each(&iter, callback);
    }
}