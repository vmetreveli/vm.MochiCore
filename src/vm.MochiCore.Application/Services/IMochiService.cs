using vm.MochiCore.Application.Features.Mochi.Command.CreateMochi;
using vm.MochiCore.Application.Features.Mochi.Command.UpdateMochi;
using vm.MochiCore.Application.Features.Mochi.Contracts;

namespace vm.MochiCore.Application.Services;

public interface IMochiService
{

    public Task Create(CreateMochiCommand request,CancellationToken cancellationToken = default);
    public Task<IList<MochiResponse>> GetAll(CancellationToken cancellationToken = default);
    public Task<MochiResponse> GetById(Guid id,CancellationToken cancellationToken = default);
    public Task Update(UpdateMochiCommand request,CancellationToken cancellationToken = default );
    
}