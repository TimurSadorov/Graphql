namespace Common.Models;

public class BaseEntity<TId>
{
    public TId Id { get; set; } = default!;
}