﻿// Each/T10.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/World.cs
namespace Flecs.NET.Core;
             
public unsafe partial struct World
{
    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Ecs.EachRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Ecs.EachEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Ecs.EachIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, ref T9, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Ecs.EachPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Ecs.EachEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Ecs.EachIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }

    /// <summary>
    ///     Iterates over the world using the provided .Each callback.
    /// </summary>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam> <typeparam name="T9">The T9 component type.</typeparam>
    public void Each<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, T9*, void> callback)
    {
        using Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> query = Query<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>();
        query.Each(callback);   
    }
}