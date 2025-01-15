using Framework.Abstractions.Commands;
using vm.MochiCore.Application.Services;

namespace vm.MochiCore.Application.Features.Mochi.Command.CreateMochi;

public class CreateMochiCommandHandler(IMochiService mochiService): ICommandHandler<CreateMochiCommand>
{
    public async Task Handle(CreateMochiCommand command, CancellationToken cancellationToken = default)
    {
        await mochiService.Create(command, cancellationToken);
    }
}