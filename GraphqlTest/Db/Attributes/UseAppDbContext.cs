namespace GraphqlTest.Db.Attributes;

public class UseAppDbContext: UseDbContextAttribute
{
    public UseAppDbContext() : base(typeof(AppDbContext))
    {
    }
}