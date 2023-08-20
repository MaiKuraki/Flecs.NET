using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Flecs.NET.Utilities;
using static Flecs.NET.Bindings.Native;

namespace Flecs.NET.Core
{
    public static unsafe class EnumType<T>
    {
        public static EnumPair[] Data { get; private set; }

        public static void Init(ecs_world_t* world, ulong id)
        {
            ecs_cpp_enum_init(world, id);

            Type type = typeof(T);

            if (RuntimeFeature.IsDynamicCodeSupported)
            {
                Array values = type.GetEnumValues();
                Data = new EnumPair[values.Length];

                for (int i = 0; i < values.Length; i++)
                {
                    object obj = values.GetValue(i);

                    T member = (T)obj;
                    int value = Convert.ToInt32(obj, CultureInfo.InvariantCulture);

                    using NativeString nativeName = (NativeString)member.ToString();
                    ulong enumEntity = ecs_cpp_enum_constant_register(world, id, 0, nativeName, value);

                    Data[i] = new EnumPair(value, enumEntity);
                }
            }
            else
            {
                // TODO: Reimplement NativeAOT support after move to .NET Standard 2.1
            }
        }

        public static ulong Id(T member, ecs_world_t* world)
        {
            Type<T>.Id(world);

            int value = Convert.ToInt32(member, CultureInfo.InvariantCulture);

            for (int i = 0; i < Data.Length; i++)
            {
                EnumPair enumPair = Data[i];
                if (enumPair.Value == value)
                    return enumPair.Id;
            }

            throw new InvalidOperationException("Failed to find entity associated with enum member.");
        }

        public struct EnumPair
        {
            public int Value { get; }
            public ulong Id { get; }

            public EnumPair(int value, ulong id)
            {
                Value = value;
                Id = id;
            }
        }
    }
}