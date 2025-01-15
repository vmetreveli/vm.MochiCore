namespace vm.MochiCore.Application.Features.Mochi.Contracts;

public class MochiResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Amount { get; set; }
    public  string Description { get; set; }
}