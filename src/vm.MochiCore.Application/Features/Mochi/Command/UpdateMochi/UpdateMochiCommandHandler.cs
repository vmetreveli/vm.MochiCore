using Framework.Abstractions.Commands;
using vm.MochiCore.Application.Services;

namespace vm.MochiCore.Application.Features.Mochi.Command.UpdateMochi;

public sealed class UpdateMochiCommandHandler(IMochiService mochiService):ICommandHandler<UpdateMochiCommand>
{
    public async Task Handle(UpdateMochiCommand command, CancellationToken cancellationToken = default)
    {
        await mochiService.Update(command, cancellationToken);
    }
}