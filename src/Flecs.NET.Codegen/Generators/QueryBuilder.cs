using Flecs.NET.Codegen.Helpers;

namespace Flecs.NET.Codegen.Generators;

public class QueryBuilder : GeneratorBase
{
    public override void Generate()
    {
        for (int i = 0; i < Generator.GenericCount; i++)
        {
            AddSource($"QueryBuilder/T{i + 1}.g.cs", GenerateQueryBuilder(i));
            AddSource($"QueryBuilder.QueryBuilder/T{i + 1}.g.cs", GenerateExtensions(Type.QueryBuilder, i));
        }
    }

    private static string GenerateQueryBuilder(int i)
    {
        return $$"""
            #nullable enable

            using static Flecs.NET.Bindings.flecs;

            namespace Flecs.NET.Core;

            /// <summary>
            ///     A type-safe wrapper around <see cref="QueryBuilder"/> that takes {{i + 1}} type arguments.
            /// </summary>
            /// {{Generator.XmlTypeParameters[i]}}
            public unsafe partial struct {{Generator.GetTypeName(Type.QueryBuilder, i)}} : IQueryBuilder<{{Generator.GetTypeName(Type.QueryBuilder, i)}}, {{Generator.GetTypeName(Type.Query, i)}}>
            {
                private QueryBuilder _queryBuilder;
            
                ref QueryBuilder IQueryBuilderBase.QueryBuilder => ref _queryBuilder;
                
                /// <inheritdoc cref="QueryBuilder.World"/>
                public ref ecs_world_t* World => ref _queryBuilder.World;
                
                /// <inheritdoc cref="QueryBuilder.Desc"/>
                public ref ecs_query_desc_t Desc => ref _queryBuilder.Desc;
            
                /// <inheritdoc cref="QueryBuilder(ecs_world_t*)"/>
                public QueryBuilder(ecs_world_t* world)
                {
                    {{Generator.GetTypeName(Type.TypeHelper, i)}}.AssertNoTags();
                    _queryBuilder = new QueryBuilder(world){{Generator.WithChain[i]}};
                }
            
                /// <inheritdoc cref="QueryBuilder(ecs_world_t*, ulong)"/>
                public QueryBuilder(ecs_world_t* world, ulong entity)
                {
                    {{Generator.GetTypeName(Type.TypeHelper, i)}}.AssertNoTags();
                    _queryBuilder = new QueryBuilder(world, entity){{Generator.WithChain[i]}};
                }
            
                /// <inheritdoc cref="QueryBuilder(ecs_world_t*, string)"/>
                public QueryBuilder(ecs_world_t* world, string name)
                {
                    {{Generator.GetTypeName(Type.TypeHelper, i)}}.AssertNoTags();
                    _queryBuilder = new QueryBuilder(world, name){{Generator.WithChain[i]}};
                }
            
                /// <inheritdoc cref="QueryBuilder.Build()"/>
                public {{Generator.GetTypeName(Type.Query, i)}} Build()
                {
                    return new {{Generator.GetTypeName(Type.Query, i)}}(_queryBuilder.Build());
                }
                
                /// <inheritdoc cref="QueryBuilder.Equals(QueryBuilder)"/>
                public bool Equals({{Generator.GetTypeName(Type.QueryBuilder, i)}} other)
                {
                    return _queryBuilder == other._queryBuilder;
                }
            
                /// <inheritdoc cref="QueryBuilder.Equals(object)"/>
                public override bool Equals(object? obj)
                {
                    return obj is {{Generator.GetTypeName(Type.QueryBuilder, i)}}  other && Equals(other);
                }
            
                /// <inheritdoc cref="QueryBuilder.GetHashCode()"/>
                public override int GetHashCode()
                {
                    return _queryBuilder.GetHashCode();
                }
            
                /// <inheritdoc cref="QueryBuilder.op_Equality"/>
                public static bool operator ==({{Generator.GetTypeName(Type.QueryBuilder, i)}} left, {{Generator.GetTypeName(Type.QueryBuilder, i)}} right)
                {
                    return left.Equals(right);
                }
            
                /// <inheritdoc cref="QueryBuilder.op_Inequality"/>
                public static bool operator !=({{Generator.GetTypeName(Type.QueryBuilder, i)}} left, {{Generator.GetTypeName(Type.QueryBuilder, i)}} right)
                {
                    return !(left == right);
                }
            }
            """;
    }

    public static string GenerateExtensions(Type type, int i = -1)
    {
        return $$"""
            using System;
            using static Flecs.NET.Bindings.flecs;

            namespace Flecs.NET.Core;

            public unsafe partial struct {{Generator.GetTypeName(type, i)}}
            {
                /// <inheritdoc cref="Core.QueryBuilder.Self()"/>
                public ref {{Generator.GetTypeName(type, i)}} Self()
                {
                    Ecs.GetQueryBuilder(ref this).Self();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Id(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Id(ulong id)
                {
                    Ecs.GetQueryBuilder(ref this).Id(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Entity(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Entity(ulong entity)
                {
                    Ecs.GetQueryBuilder(ref this).Entity(entity);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Name(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Name(string name)
                {
                    Ecs.GetQueryBuilder(ref this).Name(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Var(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Var(string name)
                {
                    Ecs.GetQueryBuilder(ref this).Var(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Term(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Term(ulong id)
                {
                    Ecs.GetQueryBuilder(ref this).Term(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Src()"/>
                public ref {{Generator.GetTypeName(type, i)}} Src()
                {
                    Ecs.GetQueryBuilder(ref this).Src();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.First()"/>
                public ref {{Generator.GetTypeName(type, i)}} First()
                {
                    Ecs.GetQueryBuilder(ref this).First();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Second()"/>
                public ref {{Generator.GetTypeName(type, i)}} Second()
                {
                    Ecs.GetQueryBuilder(ref this).Second();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Src(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Src(ulong srcId)
                {
                    Ecs.GetQueryBuilder(ref this).Src(srcId);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Src{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Src<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Src<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Src{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Src<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Src(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Src(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Src(string name)
                {
                    Ecs.GetQueryBuilder(ref this).Src(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.First(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} First(ulong firstId)
                {
                    Ecs.GetQueryBuilder(ref this).First(firstId);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.First{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} First<T>()
                {
                    Ecs.GetQueryBuilder(ref this).First<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.First{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} First<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).First(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.First(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} First(string name)
                {
                    Ecs.GetQueryBuilder(ref this).First(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Second(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Second(ulong secondId)
                {
                    Ecs.GetQueryBuilder(ref this).Second(secondId);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Second{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Second<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Second<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Second{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Second<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Second(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Second(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Second(string secondName)
                {
                    Ecs.GetQueryBuilder(ref this).Second(secondName);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Up(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Up(ulong traverse = 0)
                {
                    Ecs.GetQueryBuilder(ref this).Up(traverse);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Up{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Up<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Up<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Up{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Up<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Up(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Cascade(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Cascade(ulong traverse = 0)
                {
                    Ecs.GetQueryBuilder(ref this).Cascade(traverse);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Cascade{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Cascade<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Cascade<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Cascade{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Cascade<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Cascade(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Descend()"/>
                public ref {{Generator.GetTypeName(type, i)}} Descend()
                {
                    Ecs.GetQueryBuilder(ref this).Descend();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Parent()"/>
                public ref {{Generator.GetTypeName(type, i)}} Parent()
                {
                    Ecs.GetQueryBuilder(ref this).Parent();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Trav(ulong, uint)"/>
                public ref {{Generator.GetTypeName(type, i)}} Trav(ulong traverse, uint flags = 0)
                {
                    Ecs.GetQueryBuilder(ref this).Trav(traverse, flags);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Trav{T}(uint)"/>
                public ref {{Generator.GetTypeName(type, i)}} Trav<T>(uint flags = 0)
                {
                    Ecs.GetQueryBuilder(ref this).Trav<T>(flags);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Trav{T}(T, uint)"/>
                public ref {{Generator.GetTypeName(type, i)}} Trav<T>(T value, uint flags = 0) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Trav(value, flags);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Flags"/>
                public ref {{Generator.GetTypeName(type, i)}} Flags(ulong flags)
                {
                    Ecs.GetQueryBuilder(ref this).Flags(flags);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.InOut(ecs_inout_kind_t)"/>
                public ref {{Generator.GetTypeName(type, i)}} InOut(ecs_inout_kind_t inOut)
                {
                    Ecs.GetQueryBuilder(ref this).InOut(inOut);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.InOutStage(ecs_inout_kind_t)"/>
                public ref {{Generator.GetTypeName(type, i)}} InOutStage(ecs_inout_kind_t inOut)
                {
                    Ecs.GetQueryBuilder(ref this).InOutStage(inOut);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write()"/>
                public ref {{Generator.GetTypeName(type, i)}} Write()
                {
                    Ecs.GetQueryBuilder(ref this).Write();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read()"/>
                public ref {{Generator.GetTypeName(type, i)}} Read()
                {
                    Ecs.GetQueryBuilder(ref this).Read();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.ReadWrite()"/>
                public ref {{Generator.GetTypeName(type, i)}} ReadWrite()
                {
                    Ecs.GetQueryBuilder(ref this).ReadWrite();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.In()"/>
                public ref {{Generator.GetTypeName(type, i)}} In()
                {
                    Ecs.GetQueryBuilder(ref this).In();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Out()"/>
                public ref {{Generator.GetTypeName(type, i)}} Out()
                {
                    Ecs.GetQueryBuilder(ref this).Out();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.InOut()"/>
                public ref {{Generator.GetTypeName(type, i)}} InOut()
                {
                    Ecs.GetQueryBuilder(ref this).InOut();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.InOutNone()"/>
                public ref {{Generator.GetTypeName(type, i)}} InOutNone()
                {
                    Ecs.GetQueryBuilder(ref this).InOutNone();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Oper(ecs_oper_kind_t)"/>
                public ref {{Generator.GetTypeName(type, i)}} Oper(ecs_oper_kind_t oper)
                {
                    Ecs.GetQueryBuilder(ref this).Oper(oper);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.And()"/>
                public ref {{Generator.GetTypeName(type, i)}} And()
                {
                    Ecs.GetQueryBuilder(ref this).And();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Or()"/>
                public ref {{Generator.GetTypeName(type, i)}} Or()
                {
                    Ecs.GetQueryBuilder(ref this).Or();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Not()"/>
                public ref {{Generator.GetTypeName(type, i)}} Not()
                {
                    Ecs.GetQueryBuilder(ref this).Not();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Optional()"/>
                public ref {{Generator.GetTypeName(type, i)}} Optional()
                {
                    Ecs.GetQueryBuilder(ref this).Optional();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.AndFrom()"/>
                public ref {{Generator.GetTypeName(type, i)}} AndFrom()
                {
                    Ecs.GetQueryBuilder(ref this).AndFrom();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.OrFrom()"/>
                public ref {{Generator.GetTypeName(type, i)}} OrFrom()
                {
                    Ecs.GetQueryBuilder(ref this).OrFrom();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.NotFrom()"/>
                public ref {{Generator.GetTypeName(type, i)}} NotFrom()
                {
                    Ecs.GetQueryBuilder(ref this).NotFrom();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Singleton()"/>
                public ref {{Generator.GetTypeName(type, i)}} Singleton()
                {
                    Ecs.GetQueryBuilder(ref this).Singleton();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Filter()"/>
                public ref {{Generator.GetTypeName(type, i)}} Filter()
                {
                    Ecs.GetQueryBuilder(ref this).Filter();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.QueryFlags"/>
                public ref {{Generator.GetTypeName(type, i)}} QueryFlags(uint flags)
                {
                    Ecs.GetQueryBuilder(ref this).QueryFlags(flags);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.CacheKind(ecs_query_cache_kind_t)"/>
                public ref {{Generator.GetTypeName(type, i)}} CacheKind(ecs_query_cache_kind_t kind)
                {
                    Ecs.GetQueryBuilder(ref this).CacheKind(kind);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Cached()"/>
                public ref {{Generator.GetTypeName(type, i)}} Cached()
                {
                    Ecs.GetQueryBuilder(ref this).Cached();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Expr(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Expr(string expr)
                {
                    Ecs.GetQueryBuilder(ref this).Expr(expr);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(Core.Term)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(Term term)
                {
                    Ecs.GetQueryBuilder(ref this).With(term);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(ulong id)
                {
                    Ecs.GetQueryBuilder(ref this).With(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(string name)
                {
                    Ecs.GetQueryBuilder(ref this).With(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(ulong, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(ulong first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).With(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(ulong, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(ulong first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).With(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(string, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(string first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).With(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With(string, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} With(string first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).With(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} With<T>()
                {
                    Ecs.GetQueryBuilder(ref this).With<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).With(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T1}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TFirst>(ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).With<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T1}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TFirst>(string second)
                {
                    Ecs.GetQueryBuilder(ref this).With<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}()"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TFirst, TSecond>()
                {
                    Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}(T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T1, T2}(T1)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).With<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T1}(T1, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TFirst>(TFirst first, string second) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).With(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.With{T2}(string, T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} With<TSecond>(string first, TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).With(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.WithSecond{T2}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} WithSecond<TSecond>(ulong first)
                {
                    Ecs.GetQueryBuilder(ref this).WithSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.WithSecond{T2}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} WithSecond<TSecond>(string first)
                {
                    Ecs.GetQueryBuilder(ref this).WithSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(Core.Term)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(Term term)
                {
                    Ecs.GetQueryBuilder(ref this).Without(term);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(ulong id)
                {
                    Ecs.GetQueryBuilder(ref this).Without(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(string name)
                {
                    Ecs.GetQueryBuilder(ref this).Without(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(ulong, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(ulong first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Without(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(ulong, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(ulong first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).Without(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(string, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(string first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Without(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without(string, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without(string first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).Without(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Without<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Without(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TFirst>(ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Without<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TFirst>(string second)
                {
                    Ecs.GetQueryBuilder(ref this).Without<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TFirst, TSecond>()
                {
                    Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}(T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T1, T2}(T1)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Without<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T1}(T1, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TFirst>(TFirst first, string second) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Without(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Without{T2}(string, T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} Without<TSecond>(string first, TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Without(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.WithoutSecond{T2}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} WithoutSecond<TSecond>(ulong first)
                {
                    Ecs.GetQueryBuilder(ref this).WithoutSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.WithoutSecond{T2}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} WithoutSecond<TSecond>(string first)
                {
                    Ecs.GetQueryBuilder(ref this).WithoutSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(Core.Term)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(Term term)
                {
                    Ecs.GetQueryBuilder(ref this).Write(term);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(ulong id)
                {
                    Ecs.GetQueryBuilder(ref this).Write(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(string name)
                {
                    Ecs.GetQueryBuilder(ref this).Write(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(ulong, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(ulong first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Write(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(ulong, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(ulong first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).Write(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(string, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(string first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Write(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write(string, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write(string first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).Write(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Write<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Write(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TFirst>(ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Write<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TFirst>(string second)
                {
                    Ecs.GetQueryBuilder(ref this).Write<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TFirst, TSecond>()
                {
                    Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}(T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T1, T2}(T1)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Write<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T1}(T1, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TFirst>(TFirst first, string second) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Write(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Write{T2}(string, T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} Write<TSecond>(string first, TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Write(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.WriteSecond{T2}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} WriteSecond<TSecond>(ulong first)
                {
                    Ecs.GetQueryBuilder(ref this).WriteSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.WriteSecond{T2}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} WriteSecond<TSecond>(string first)
                {
                    Ecs.GetQueryBuilder(ref this).WriteSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(Core.Term)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(Term term)
                {
                    Ecs.GetQueryBuilder(ref this).Read(term);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(ulong id)
                {
                    Ecs.GetQueryBuilder(ref this).Read(id);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(string name)
                {
                    Ecs.GetQueryBuilder(ref this).Read(name);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(ulong, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(ulong first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Read(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(ulong, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(ulong first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).Read(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(string, ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(string first, ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Read(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read(string, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read(string first, string second)
                {
                    Ecs.GetQueryBuilder(ref this).Read(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<T>()
                {
                    Ecs.GetQueryBuilder(ref this).Read<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<T>(T value) where T : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Read(value);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TFirst>(ulong second)
                {
                    Ecs.GetQueryBuilder(ref this).Read<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TFirst>(string second)
                {
                    Ecs.GetQueryBuilder(ref this).Read<TFirst>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}()"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TFirst, TSecond>()
                {
                    Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}(T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TFirst, TSecond>(TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>(second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T1, T2}(T1)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TFirst, TSecond>(TFirst first) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Read<TFirst, TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T1}(T1, string)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TFirst>(TFirst first, string second) where TFirst : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Read(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Read{T2}(string, T2)"/>
                public ref {{Generator.GetTypeName(type, i)}} Read<TSecond>(string first, TSecond second) where TSecond : Enum
                {
                    Ecs.GetQueryBuilder(ref this).Read(first, second);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.ReadSecond{T2}(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} ReadSecond<TSecond>(ulong first)
                {
                    Ecs.GetQueryBuilder(ref this).ReadSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.ReadSecond{T2}(string)"/>
                public ref {{Generator.GetTypeName(type, i)}} ReadSecond<TSecond>(string first)
                {
                    Ecs.GetQueryBuilder(ref this).ReadSecond<TSecond>(first);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.ScopeOpen()"/>
                public ref {{Generator.GetTypeName(type, i)}} ScopeOpen()
                {
                    Ecs.GetQueryBuilder(ref this).ScopeOpen();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.ScopeClose()"/>
                public ref {{Generator.GetTypeName(type, i)}} ScopeClose()
                {
                    Ecs.GetQueryBuilder(ref this).ScopeClose();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.Term()"/>
                public ref {{Generator.GetTypeName(type, i)}} Term()
                {
                    Ecs.GetQueryBuilder(ref this).Term();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.TermAt{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} TermAt<T>()
                {
                    Ecs.GetQueryBuilder(ref this).TermAt<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.TermAt(int)"/>
                public ref {{Generator.GetTypeName(type, i)}} TermAt(int termIndex)
                {
                    Ecs.GetQueryBuilder(ref this).TermAt(termIndex);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.TermAt{T}(int)"/>
                public ref {{Generator.GetTypeName(type, i)}} TermAt<T>(int termIndex)
                {
                    Ecs.GetQueryBuilder(ref this).TermAt<T>(termIndex);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.OrderBy(ulong, Ecs.OrderByCallback)"/>
                public ref {{Generator.GetTypeName(type, i)}} OrderBy(ulong component, Ecs.OrderByCallback callback)
                {
                    Ecs.GetQueryBuilder(ref this).OrderBy(component, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.OrderBy{T}(Ecs.OrderByCallback)"/>
                public ref {{Generator.GetTypeName(type, i)}} OrderBy<T>(Ecs.OrderByCallback callback)
                {
                    Ecs.GetQueryBuilder(ref this).OrderBy<T>(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong)"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupBy(ulong component)
                {
                    Ecs.GetQueryBuilder(ref this).GroupBy(component);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.GroupBy(ulong, Ecs.GroupByCallback)"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupBy(ulong component, Ecs.GroupByCallback callback)
                {
                    Ecs.GetQueryBuilder(ref this).GroupBy(component, callback);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.GroupBy{TContext}(ulong, Ecs.GroupByCallback{TContext})"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupBy<TContext>(ulong component, Ecs.GroupByCallback<TContext> callback)
                {
                    Ecs.GetQueryBuilder(ref this).GroupBy(component, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}()"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupBy<T>()
                {
                    Ecs.GetQueryBuilder(ref this).GroupBy<T>();
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T}(Ecs.GroupByCallback)"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupBy<T>(Ecs.GroupByCallback callback)
                {
                    Ecs.GetQueryBuilder(ref this).GroupBy<T>(callback);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.GroupBy{T, TContext}(Ecs.GroupByCallback{TContext})"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupBy<T, TContext>(Ecs.GroupByCallback<TContext> callback)
                {
                    Ecs.GetQueryBuilder(ref this).GroupBy<T, TContext>(callback);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.GroupByCtx{T}(T)"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupByCtx<T>(T value)
                {
                    Ecs.GetQueryBuilder(ref this).GroupByCtx(value);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.GroupByCtx{T}(T, Ecs.UserContextFinish{T})"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupByCtx<T>(T value, Ecs.UserContextFinish<T> callback)
                {
                    Ecs.GetQueryBuilder(ref this).GroupByCtx(value, callback);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.GroupByCtx{T}(T, Ecs.UserContextFinish{T})"/>
                public ref {{Generator.GetTypeName(type, i)}} GroupByCtx<T>(T value, delegate*<ref T, void> callback)
                {
                    Ecs.GetQueryBuilder(ref this).GroupByCtx(value, callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.OnGroupCreate(Ecs.GroupCreateCallback)"/>
                public ref {{Generator.GetTypeName(type, i)}} OnGroupCreate(Ecs.GroupCreateCallback callback)
                {
                    Ecs.GetQueryBuilder(ref this).OnGroupCreate(callback);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.OnGroupCreate{T}(Ecs.GroupCreateCallback{T})"/>
                public ref {{Generator.GetTypeName(type, i)}} OnGroupCreate<T>(Ecs.GroupCreateCallback<T> callback)
                {
                    Ecs.GetQueryBuilder(ref this).OnGroupCreate(callback);
                    return ref this;
                }
            
                /// <inheritdoc cref="Core.QueryBuilder.OnGroupDelete(Ecs.GroupDeleteCallback)"/>
                public ref {{Generator.GetTypeName(type, i)}} OnGroupDelete(Ecs.GroupDeleteCallback callback)
                {
                    Ecs.GetQueryBuilder(ref this).OnGroupDelete(callback);
                    return ref this;
                }
                
                /// <inheritdoc cref="Core.QueryBuilder.OnGroupDelete{T}(Ecs.GroupDeleteCallback{T})"/>
                public ref {{Generator.GetTypeName(type, i)}} OnGroupDelete<T>(Ecs.GroupDeleteCallback<T> callback)
                {
                    Ecs.GetQueryBuilder(ref this).OnGroupDelete(callback);
                    return ref this;
                }
            }
            """;
    }
}
