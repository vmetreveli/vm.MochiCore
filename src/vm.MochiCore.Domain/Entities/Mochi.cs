using Framework.Abstractions.Primitives;

namespace vm.MochiCore.Domain.Entities;

public class Mochi : AggregateRoot<Guid>, IAuditableEntity, IDeletableEntity
{
    public Mochi(string name, decimal amount, string description) : base(Guid.NewGuid())
    {
        Name = name;
        Amount = amount;
        Description = description;
    }

    public Mochi() : base(Guid.NewGuid())
    {

    }

    public string Name { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public DateTime CreatedOn { get; } = DateTime.Now;
    public DateTime ModifiedOn { get; }
    public bool IsDeleted { get; }
    public DateTime? DeletedOn { get; }
}