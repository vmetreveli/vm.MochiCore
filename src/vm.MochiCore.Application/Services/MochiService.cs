using Framework.Abstractions.Repository;
using Framework.Infrastructure.Exceptions;
using vm.MochiCore.Application.Features.Mochi.Command.CreateMochi;
using vm.MochiCore.Application.Features.Mochi.Command.UpdateMochi;
using vm.MochiCore.Application.Features.Mochi.Contracts;
using vm.MochiCore.Domain.Exception.Mochi;
using vm.MochiCore.Domain.Repository;

namespace vm.MochiCore.Application.Services;

public class MochiService(IMochiRepository mochiRepository, IUnitOfWork unitOfWork) : IMochiService
{
    public async Task Create(CreateMochiCommand request, CancellationToken cancellationToken)
    {
     
        var res = await mochiRepository.GetByNameAsync(request.Name, cancellationToken);

        if (res is not null)
        {
            throw new MochiException(MochiErrors.Duplicate(res.Name));
        }

        var model = new Domain.Entities.Mochi
        {
            Name = request.Name,
            Description = request.Description,
            Amount = (decimal) request.Amount!
        };


        await mochiRepository.AddAsync(model, cancellationToken);
        await unitOfWork.CompleteAsync(cancellationToken);
    }

    public async Task<IList<MochiResponse>> GetAll(CancellationToken cancellationToken)
    {
        var res = await mochiRepository.GetAllAsync(cancellationToken);

        if (res is null)
        {
            throw new ObjectNotFoundException(typeof(Domain.Entities.Mochi).ToString(), string.Empty);
        }

        return res!.Select(i => new MochiResponse { Id = i.Id, Name = i.Name, Amount = i.Amount }).ToList();
    }


    public async Task<MochiResponse> GetById(Guid id, CancellationToken cancellationToken)
    {
        var res = await mochiRepository.GetByIdAsync(id, cancellationToken);

        if (res is  null)
        {
            throw new ObjectNotFoundException($"The id {id} not Found", string.Empty);
        }

        return new MochiResponse
        {
            Id = res.Id,
            Name = res.Name,
            Description = res.Description,
            Amount = res.Amount
        };
    }

    public async Task Update(UpdateMochiCommand request, CancellationToken cancellationToken)
    {

        var res = await mochiRepository.GetByIdAsync(request.Id, cancellationToken);
        if (res is  null)
        {
            throw new ObjectNotFoundException($"The id {request.Id} not Found", string.Empty);
        }

        if (request.Amount is null or 0)
        {
            throw new MochiException(MochiErrors.Amount.NullOrEmpty);
        }
        if (request.Description is null)
        {
            throw new MochiException(MochiErrors.Description.NullOrEmpty);
        }

        if (request.Amount != res.Amount)
        {
            res.Amount = (decimal) request.Amount!;
        }

        if (request.Description != res.Description)
        {
            res.Description = request.Description;
        }
       
    }
}