// This example shows how the OnGroupCreate and OnGroupDelete callbacks can
// be used to get notified when a new group is registered for a query. These
// callbacks make it possible to associate and manage user data attached to
// groups.

using System.Runtime.InteropServices;
using Flecs.NET.Bindings;
using Flecs.NET.Core;

// Components
file record struct Position(float X, float Y);

// Custom type to associate with group
file record struct GroupCtx(int Counter);

// Dummy tag to put entities in different tables
file struct Tag;

// Create a relationship to use for the group_by function. Tables will
// be assigned the relationship target as group id
file struct Group;

// Targets for the relationship, which will be used as group ids.
file struct First;
file struct Second;
file struct Third;

public static unsafe class Queries_GroupByCallbacks
{
    public static void Main()
    {
        using World world = World.Create();

        // Register components in order so that id for First is lower than Third
        world.Component<First>();
        world.Component<Second>();
        world.Component<Third>();

        int groupCounter = 0;

        // Grouped query
        using Query<Position> q = world.QueryBuilder<Position>()
            .GroupBy<Group>()
            // Callback invoked when a new group is created. Including the third "out T" parameter
            // allows you to provide a user context.
            .OnGroupCreate((World world, ulong id, out GroupCtx ctx) =>
            {
                Console.WriteLine($"Group {world.Entity(id)} created");

                // Set data that will be associated with the group
                ctx = new GroupCtx(++groupCounter);
            })
            // Callback invoked when a group is deleted. Including the third "ref T" parameter
            // provides access to the user context object.
            .OnGroupDelete((World world, ulong id, ref GroupCtx ctx) =>
            {
                Console.WriteLine($"Group {world.Entity(id)} deleted");
            })
            .Build();

        // Create entities in 6 different tables with 3 group ids
        world.Entity().Add<Group, Third>()
            .Set(new Position(1, 1));
        world.Entity().Add<Group, Second>()
            .Set(new Position(2, 2));
        world.Entity().Add<Group, First>()
            .Set(new Position(3, 3));

        world.Entity().Add<Group, Third>()
            .Set(new Position(4, 4))
            .Add<Tag>();
        world.Entity().Add<Group, Second>()
            .Set(new Position(5, 5))
            .Add<Tag>();
        world.Entity().Add<Group, First>()
            .Set(new Position(6, 6))
            .Add<Tag>();

        // The query cache now looks like this:
        //  - group First:
        //     - table [Position, (Group, First)]
        //     - table [Position, Tag, (Group, First)]
        //
        //  - group Second:
        //     - table [Position, (Group, Second)]
        //     - table [Position, Tag, (Group, Second)]
        //
        //  - group Third:
        //     - table [Position, (Group, Third)]
        //     - table [Position, Tag, (Group, Third)]
        //

        q.Run((Iter it) =>
        {
            while (it.Next())
            {
                Field<Position> p = it.Field<Position>(0);

                Entity group = it.World().Entity(it.GroupId());
                ref GroupCtx ctx = ref it.Query().GroupCtx<GroupCtx>(group);

                Console.WriteLine($" - Group {group.Path()}: table [{it.Table().Str()}]");
                Console.WriteLine($"    Counter: {ctx.Counter}");

                foreach (int i in it)
                    Console.WriteLine($"    ({p[i].X}, {p[i].Y})");

                Console.WriteLine();
            }
        });

        // Deleting the query will call the OnGroupDeleted callback
        q.Destruct();
    }
}

// Output:
// Group Third created
// Group Second created
// Group First created
//
//  - Group .First: table [Position, (Group,First)]
//     Counter: 3
//     (3, 3)
//
//  - Group .First: table [Position, Tag, (Group,First)]
//     Counter: 3
//     (6, 6)
//
//  - Group .Second: table [Position, (Group,Second)]
//     Counter: 2
//     (2, 2)
//
//  - Group .Second: table [Position, Tag, (Group,Second)]
//     Counter: 2
//     (5, 5)
//
//  - Group .Third: table [Position, (Group,Third)]
//     Counter: 1
//     (1, 1)
//
//  - Group .Third: table [Position, Tag, (Group,Third)]
//     Counter: 1
//     (4, 4)
//
// Group First deleted
// Group Third deleted
// Group Second deleted
