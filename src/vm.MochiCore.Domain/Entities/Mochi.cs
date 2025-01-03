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
    public DateTime CreatedOn { get; set; } = DateTime.Now;
    public DateTime ModifiedOn { get; set; }
    public bool IsDeleted { get; set; } = false;
    public DateTime? DeletedOn { get; set; }
}