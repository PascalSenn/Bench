using Bench.HotChocolate.Types;
using HotChocolate;
using HotChocolate.Execution;

namespace Bench.HotChocolate
{
    public static class Setup
    {
        public static IQueryExecutor Create()
        {
            return SchemaBuilder.New()
                .AddQueryType<QueryType>()
                .AddType<DroidType>()
                .AddType<HumanType>()
                .Create()
                .MakeExecutable();
        }
    }
}
