﻿// Find/Iterator/T9.g.cs
// File was auto-generated by /_/src/Flecs.NET.Codegen/Generators/Invoker.cs
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.flecs;

namespace Flecs.NET.Core;

public static unsafe partial class Invoker
{
    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, Ecs.FindRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(ref Managed.GetTypeRef<T0>(&pointer0[i]), ref Managed.GetTypeRef<T1>(&pointer1[i]), ref Managed.GetTypeRef<T2>(&pointer2[i]), ref Managed.GetTypeRef<T3>(&pointer3[i]), ref Managed.GetTypeRef<T4>(&pointer4[i]), ref Managed.GetTypeRef<T5>(&pointer5[i]), ref Managed.GetTypeRef<T6>(&pointer6[i]), ref Managed.GetTypeRef<T7>(&pointer7[i]), ref Managed.GetTypeRef<T8>(&pointer8[i])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(ref Managed.GetTypeRef<T0>(&pointer0[i * step0]), ref Managed.GetTypeRef<T1>(&pointer1[i * step1]), ref Managed.GetTypeRef<T2>(&pointer2[i * step2]), ref Managed.GetTypeRef<T3>(&pointer3[i * step3]), ref Managed.GetTypeRef<T4>(&pointer4[i * step4]), ref Managed.GetTypeRef<T5>(&pointer5[i * step5]), ref Managed.GetTypeRef<T6>(&pointer6[i * step6]), ref Managed.GetTypeRef<T7>(&pointer7[i * step7]), ref Managed.GetTypeRef<T8>(&pointer8[i * step8])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, Ecs.FindEntityRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(&pointer0[i]), ref Managed.GetTypeRef<T1>(&pointer1[i]), ref Managed.GetTypeRef<T2>(&pointer2[i]), ref Managed.GetTypeRef<T3>(&pointer3[i]), ref Managed.GetTypeRef<T4>(&pointer4[i]), ref Managed.GetTypeRef<T5>(&pointer5[i]), ref Managed.GetTypeRef<T6>(&pointer6[i]), ref Managed.GetTypeRef<T7>(&pointer7[i]), ref Managed.GetTypeRef<T8>(&pointer8[i])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(&pointer0[i * step0]), ref Managed.GetTypeRef<T1>(&pointer1[i * step1]), ref Managed.GetTypeRef<T2>(&pointer2[i * step2]), ref Managed.GetTypeRef<T3>(&pointer3[i * step3]), ref Managed.GetTypeRef<T4>(&pointer4[i * step4]), ref Managed.GetTypeRef<T5>(&pointer5[i * step5]), ref Managed.GetTypeRef<T6>(&pointer6[i * step6]), ref Managed.GetTypeRef<T7>(&pointer7[i * step7]), ref Managed.GetTypeRef<T8>(&pointer8[i * step8])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, Ecs.FindIterRefCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, ref Managed.GetTypeRef<T0>(&pointer0[i]), ref Managed.GetTypeRef<T1>(&pointer1[i]), ref Managed.GetTypeRef<T2>(&pointer2[i]), ref Managed.GetTypeRef<T3>(&pointer3[i]), ref Managed.GetTypeRef<T4>(&pointer4[i]), ref Managed.GetTypeRef<T5>(&pointer5[i]), ref Managed.GetTypeRef<T6>(&pointer6[i]), ref Managed.GetTypeRef<T7>(&pointer7[i]), ref Managed.GetTypeRef<T8>(&pointer8[i])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, ref Managed.GetTypeRef<T0>(&pointer0[i * step0]), ref Managed.GetTypeRef<T1>(&pointer1[i * step1]), ref Managed.GetTypeRef<T2>(&pointer2[i * step2]), ref Managed.GetTypeRef<T3>(&pointer3[i * step3]), ref Managed.GetTypeRef<T4>(&pointer4[i * step4]), ref Managed.GetTypeRef<T5>(&pointer5[i * step5]), ref Managed.GetTypeRef<T6>(&pointer6[i * step6]), ref Managed.GetTypeRef<T7>(&pointer7[i * step7]), ref Managed.GetTypeRef<T8>(&pointer8[i * step8])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, delegate*<ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, bool> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(ref Managed.GetTypeRef<T0>(&pointer0[i]), ref Managed.GetTypeRef<T1>(&pointer1[i]), ref Managed.GetTypeRef<T2>(&pointer2[i]), ref Managed.GetTypeRef<T3>(&pointer3[i]), ref Managed.GetTypeRef<T4>(&pointer4[i]), ref Managed.GetTypeRef<T5>(&pointer5[i]), ref Managed.GetTypeRef<T6>(&pointer6[i]), ref Managed.GetTypeRef<T7>(&pointer7[i]), ref Managed.GetTypeRef<T8>(&pointer8[i])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(ref Managed.GetTypeRef<T0>(&pointer0[i * step0]), ref Managed.GetTypeRef<T1>(&pointer1[i * step1]), ref Managed.GetTypeRef<T2>(&pointer2[i * step2]), ref Managed.GetTypeRef<T3>(&pointer3[i * step3]), ref Managed.GetTypeRef<T4>(&pointer4[i * step4]), ref Managed.GetTypeRef<T5>(&pointer5[i * step5]), ref Managed.GetTypeRef<T6>(&pointer6[i * step6]), ref Managed.GetTypeRef<T7>(&pointer7[i * step7]), ref Managed.GetTypeRef<T8>(&pointer8[i * step8])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, delegate*<Entity, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, bool> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(&pointer0[i]), ref Managed.GetTypeRef<T1>(&pointer1[i]), ref Managed.GetTypeRef<T2>(&pointer2[i]), ref Managed.GetTypeRef<T3>(&pointer3[i]), ref Managed.GetTypeRef<T4>(&pointer4[i]), ref Managed.GetTypeRef<T5>(&pointer5[i]), ref Managed.GetTypeRef<T6>(&pointer6[i]), ref Managed.GetTypeRef<T7>(&pointer7[i]), ref Managed.GetTypeRef<T8>(&pointer8[i])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), ref Managed.GetTypeRef<T0>(&pointer0[i * step0]), ref Managed.GetTypeRef<T1>(&pointer1[i * step1]), ref Managed.GetTypeRef<T2>(&pointer2[i * step2]), ref Managed.GetTypeRef<T3>(&pointer3[i * step3]), ref Managed.GetTypeRef<T4>(&pointer4[i * step4]), ref Managed.GetTypeRef<T5>(&pointer5[i * step5]), ref Managed.GetTypeRef<T6>(&pointer6[i * step6]), ref Managed.GetTypeRef<T7>(&pointer7[i * step7]), ref Managed.GetTypeRef<T8>(&pointer8[i * step8])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, delegate*<Iter, int, ref T0, ref T1, ref T2, ref T3, ref T4, ref T5, ref T6, ref T7, ref T8, bool> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, ref Managed.GetTypeRef<T0>(&pointer0[i]), ref Managed.GetTypeRef<T1>(&pointer1[i]), ref Managed.GetTypeRef<T2>(&pointer2[i]), ref Managed.GetTypeRef<T3>(&pointer3[i]), ref Managed.GetTypeRef<T4>(&pointer4[i]), ref Managed.GetTypeRef<T5>(&pointer5[i]), ref Managed.GetTypeRef<T6>(&pointer6[i]), ref Managed.GetTypeRef<T7>(&pointer7[i]), ref Managed.GetTypeRef<T8>(&pointer8[i])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, ref Managed.GetTypeRef<T0>(&pointer0[i * step0]), ref Managed.GetTypeRef<T1>(&pointer1[i * step1]), ref Managed.GetTypeRef<T2>(&pointer2[i * step2]), ref Managed.GetTypeRef<T3>(&pointer3[i * step3]), ref Managed.GetTypeRef<T4>(&pointer4[i * step4]), ref Managed.GetTypeRef<T5>(&pointer5[i * step5]), ref Managed.GetTypeRef<T6>(&pointer6[i * step6]), ref Managed.GetTypeRef<T7>(&pointer7[i * step7]), ref Managed.GetTypeRef<T8>(&pointer8[i * step8])))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, Ecs.FindPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(&pointer0[i], &pointer1[i], &pointer2[i], &pointer3[i], &pointer4[i], &pointer5[i], &pointer6[i], &pointer7[i], &pointer8[i]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(&pointer0[i * step0], &pointer1[i * step1], &pointer2[i * step2], &pointer3[i * step3], &pointer4[i * step4], &pointer5[i * step5], &pointer6[i * step6], &pointer7[i * step7], &pointer8[i * step8]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, Ecs.FindEntityPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), &pointer0[i], &pointer1[i], &pointer2[i], &pointer3[i], &pointer4[i], &pointer5[i], &pointer6[i], &pointer7[i], &pointer8[i]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), &pointer0[i * step0], &pointer1[i * step1], &pointer2[i * step2], &pointer3[i * step3], &pointer4[i * step4], &pointer5[i * step5], &pointer6[i * step6], &pointer7[i * step7], &pointer8[i * step8]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, Ecs.FindIterPointerCallback<T0, T1, T2, T3, T4, T5, T6, T7, T8> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, &pointer0[i], &pointer1[i], &pointer2[i], &pointer3[i], &pointer4[i], &pointer5[i], &pointer6[i], &pointer7[i], &pointer8[i]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, &pointer0[i * step0], &pointer1[i * step1], &pointer2[i * step2], &pointer3[i * step3], &pointer4[i * step4], &pointer5[i * step5], &pointer6[i * step6], &pointer7[i * step7], &pointer8[i * step8]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, delegate*<T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, bool> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(&pointer0[i], &pointer1[i], &pointer2[i], &pointer3[i], &pointer4[i], &pointer5[i], &pointer6[i], &pointer7[i], &pointer8[i]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(&pointer0[i * step0], &pointer1[i * step1], &pointer2[i * step2], &pointer3[i * step3], &pointer4[i * step4], &pointer5[i * step5], &pointer6[i * step6], &pointer7[i * step7], &pointer8[i * step8]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, delegate*<Entity, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, bool> callback)
    {
        int count = it.Handle->count; Ecs.Assert(it.Handle->count > 0, "No entities returned, use Iter() or Each() without the entity argument instead.");
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), &pointer0[i], &pointer1[i], &pointer2[i], &pointer3[i], &pointer4[i], &pointer5[i], &pointer6[i], &pointer7[i], &pointer8[i]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(new Entity(it.Handle->world, it.Handle->entities[i]), &pointer0[i * step0], &pointer1[i * step1], &pointer2[i * step2], &pointer3[i * step3], &pointer4[i * step4], &pointer5[i * step5], &pointer6[i * step6], &pointer7[i * step7], &pointer8[i * step8]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }

    /// <summary>
    ///     Iterates over an Iter object using the provided .Find callback.
    /// </summary>
    /// <param name="it">The iter object.</param>
    /// <param name="callback">The callback.</param>
    /// <typeparam name="T0">The T0 component type.</typeparam> <typeparam name="T1">The T1 component type.</typeparam> <typeparam name="T2">The T2 component type.</typeparam> <typeparam name="T3">The T3 component type.</typeparam> <typeparam name="T4">The T4 component type.</typeparam> <typeparam name="T5">The T5 component type.</typeparam> <typeparam name="T6">The T6 component type.</typeparam> <typeparam name="T7">The T7 component type.</typeparam> <typeparam name="T8">The T8 component type.</typeparam>
    public static Entity Find<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Iter it, delegate*<Iter, int, T0*, T1*, T2*, T3*, T4*, T5*, T6*, T7*, T8*, bool> callback)
    {
        int count = it.Handle->count == 0 && it.Handle->table == null ? 1 : it.Handle->count;
        
        T0* pointer0 = it.GetPointer<T0>(0); T1* pointer1 = it.GetPointer<T1>(1); T2* pointer2 = it.GetPointer<T2>(2); T3* pointer3 = it.GetPointer<T3>(3); T4* pointer4 = it.GetPointer<T4>(4); T5* pointer5 = it.GetPointer<T5>(5); T6* pointer6 = it.GetPointer<T6>(6); T7* pointer7 = it.GetPointer<T7>(7); T8* pointer8 = it.GetPointer<T8>(8);
            
        Ecs.TableLock(it);
        
        Entity result = default;
            
        if (it.IsLinear())
        {
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, &pointer0[i], &pointer1[i], &pointer2[i], &pointer3[i], &pointer4[i], &pointer5[i], &pointer6[i], &pointer7[i], &pointer8[i]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
        else
        {
            int step0 = it.Step<T0>(0); int step1 = it.Step<T1>(1); int step2 = it.Step<T2>(2); int step3 = it.Step<T3>(3); int step4 = it.Step<T4>(4); int step5 = it.Step<T5>(5); int step6 = it.Step<T6>(6); int step7 = it.Step<T7>(7); int step8 = it.Step<T8>(8);
            for (int i = 0; i < count; i++)
            {
                if (!callback(it, i, &pointer0[i * step0], &pointer1[i * step1], &pointer2[i * step2], &pointer3[i * step3], &pointer4[i * step4], &pointer5[i * step5], &pointer6[i * step6], &pointer7[i * step7], &pointer8[i * step8]))
                    continue;
                    
                result = new Entity(it.Handle->world, it.Handle->entities[i]);
                break;
            }
        }
            
        Ecs.TableUnlock(it);
        
        return result;
    }
}