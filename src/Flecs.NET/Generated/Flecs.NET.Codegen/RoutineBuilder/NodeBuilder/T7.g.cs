﻿// NodeBuilder/T7.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/RoutineBuilder.cs
using System;
using Flecs.NET.Core.BindingContext;

namespace Flecs.NET.Core;

public unsafe partial struct RoutineBuilder
{
    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Iter<T0, T1, T2, T3, T4, T5, T6>(Ecs.IterFieldCallback<T0, T1, T2, T3, T4, T5, T6> callback) 
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.IterFieldCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Iter<T0, T1, T2, T3, T4, T5, T6>(Ecs.IterSpanCallback<T0, T1, T2, T3, T4, T5, T6> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.IterSpanCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Iter<T0, T1, T2, T3, T4, T5, T6>(Ecs.IterPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.IterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Iter<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, Field<T4>, Field<T5>, Field<T6>, void> callback) 
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.IterFieldCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Iter<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, Span<T4>, Span<T5>, Span<T6>, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.IterSpanCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Iter<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.IterPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6> callback) 
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6> callback) 
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachEntityRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6> callback) 
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachIterRefCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, void> callback) 
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, void> callback) 
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachEntityRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, void> callback) 
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachIterRefCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachEntityPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback(callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachIterPointerCallbackDelegate).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachEntityPointerCallbackPointer).Build();
    }

    /// <summary>
    ///     Creates <see cref="Routine"/> with the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam>
    public Routine Each<T0, T1, T2, T3, T4, T5, T6>(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged
    {
        return SetCallback((IntPtr)callback, Pointers<T0, T1, T2, T3, T4, T5, T6>.EachIterPointerCallbackPointer).Build();
    }
}