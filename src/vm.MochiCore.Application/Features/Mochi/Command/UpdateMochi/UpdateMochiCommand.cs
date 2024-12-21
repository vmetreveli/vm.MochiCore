using Framework.Abstractions.Commands;

namespace vm.MochiCore.Application.Features.Mochi.Command.UpdateMochi;

public sealed class UpdateMochiCommand:ICommand
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal? Amount { get; set; }
    public  string Description { get; set; }
}