using GraphqlTest.GraphQL.ProductHandler.Queries;
using HotChocolate.Execution.Configuration;

namespace GraphqlTest.Configuration;

public static class RequestExecutorBuilderExtension
{
    public static IRequestExecutorBuilder AddGraphqlServices(this IRequestExecutorBuilder builder)
    {
        return builder
            .AddQueryType<ProductQueries>()
            .AddProjections();
    }
}