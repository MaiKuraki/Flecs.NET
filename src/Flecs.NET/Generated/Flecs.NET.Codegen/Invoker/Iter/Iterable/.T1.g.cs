﻿// Iter/Iterable/.T1.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Invoker.cs
using System;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Invoker
{
    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Iter callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam>
    public static void Iter<T, T0>(ref T iterable, Ecs.IterFieldCallback<T0> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Iter(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Iter callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam>
    public static void Iter<T, T0>(ref T iterable, Ecs.IterSpanCallback<T0> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Iter(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Iter callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam>
    public static void Iter<T, T0>(ref T iterable, Ecs.IterPointerCallback<T0> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Iter(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Iter callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam>
    public static void Iter<T, T0>(ref T iterable, delegate*<Iter, Field<T0>, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Iter(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Iter callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam>
    public static void Iter<T, T0>(ref T iterable, delegate*<Iter, Span<T0>, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Iter(&iter, callback);
    }

    /// <summary>
    ///     Iterates over an IIterableBase object using the provided .Iter callback.
    /// </summary>
    /// <param name="iterable">The iterable object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T">The iterable type.</typeparam>
    /// <typeparam name="T0">The T0 component type.</typeparam>
    public static void Iter<T, T0>(ref T iterable, delegate*<Iter, T0*, void> callback)
        where T : unmanaged, IIterableBase
    {
        ecs_iter_t iter = iterable.GetIter();
        while (iterable.GetNext(&iter))
            Iter(&iter, callback);
    }
}