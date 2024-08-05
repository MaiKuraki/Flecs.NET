﻿// Iterators/T12.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/WorkerIterable.cs
using System;

namespace Flecs.NET.Core;

public unsafe partial struct WorkerIterable
{
    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Iter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.IterFieldCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        Invoker.Iter<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Iter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.IterSpanCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Iter<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Iter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.IterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Iter<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Iter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, Field<T0>, Field<T1>, Field<T2>, Field<T3>, Field<T4>, Field<T5>, Field<T6>, Field<T7>, Field<T8>, Field<T9>, Field<T10>, Field<T11>, void> callback) 
    {
        Invoker.Iter<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Iter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, Span<T0>, Span<T1>, Span<T2>, Span<T3>, Span<T4>, Span<T5>, Span<T6>, Span<T7>, Span<T8>, Span<T9>, Span<T10>, Span<T11>, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Iter<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Iter callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Iter<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Iter<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, void> callback) 
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, void> callback) 
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, void> callback) 
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, void> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        Invoker.Each<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.FindRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.FindEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.FindIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) 
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, bool> callback) 
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, bool> callback) 
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, ref T10, ref T11, bool> callback) 
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.FindPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.FindEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Ecs.FindIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, bool> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, bool> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }

    /// <summary>
    ///     Iterates the <see cref="WorkerIterable"/> using the provided .Find callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam> <typeparam name="T10">The T10 component type.</typeparam> <typeparam name="T11">The T11 component type.</typeparam>
    public Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, T10*, T11*, bool> callback) where T0 : unmanaged where T1 : unmanaged where T2 : unmanaged where T3 : unmanaged where T4 : unmanaged where T5 : unmanaged where T6 : unmanaged where T7 : unmanaged where T8 : unmanaged where T9 : unmanaged where T10 : unmanaged where T11 : unmanaged
    {
        return Invoker.Find<WorkerIterable, T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(ref this, callback);
    }
}