using GraphqlTest.Db;
using GraphqlTest.Db.Attributes;
using GraphqlTest.Models;

namespace GraphqlTest.GraphQL.ProductHandler.Queries;

public class ProductQueries
{
    [UseAppDbContext]
    [UseProjection]
    public IQueryable<Product> GetProducts([ScopedService] AppDbContext dbContext)
    {
        return dbContext.Products;
    }
}