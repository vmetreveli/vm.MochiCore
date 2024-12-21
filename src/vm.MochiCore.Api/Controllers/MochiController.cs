using Asp.Versioning;
using Framework.Abstractions.Dispatchers;
using vm.MochiCore.Api.Routes;
using vm.MochiCore.Application.Features.Mochi.Command.CreateMochi;
using vm.MochiCore.Application.Features.Mochi.Command.UpdateMochi;
using vm.MochiCore.Application.Features.Mochi.Queries.GetAll;
using vm.MochiCore.Application.Features.Mochi.Queries.GetById;

namespace vm.MochiCore.Api.Controllers;

[ApiVersion("1.0")]
[Route(ApiRoutes.BaseRoute)]
public class MochiController(IDispatcher dispatcher) : ApiController(dispatcher)
{
    [HttpGet]
    [Route("/")]
    [ApiSuccessResponse(StatusCodes.Status200OK)]
    [ApiErrorResponse(StatusCodes.Status400BadRequest, "Bad Request")]
    public async Task<IActionResult> Get(CancellationToken cancellationToken)
    {

        var query = new GetAllQuery();
        var res= await Dispatcher.QueryAsync(query, cancellationToken);
        return Ok(res);
    }

    [HttpGet]
    [Route("/{id:guid}")]
    [ApiSuccessResponse(StatusCodes.Status200OK)]
    [ApiErrorResponse(StatusCodes.Status400BadRequest, "Bad Request")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var query = new GetByIdQuery
        {
            Id = id
        };
        var res= await Dispatcher.QueryAsync(query, cancellationToken);
        return Ok(res);
    }

    [HttpPut]
    [ApiSuccessResponse(StatusCodes.Status204NoContent)]
    [ApiErrorResponse(StatusCodes.Status400BadRequest, "Bad Request")]
    public async Task<IActionResult> Update(UpdateMochiCommand command, CancellationToken cancellationToken)
    {

        await Dispatcher.SendAsync(command, cancellationToken);
        return NoContent();
    }

    [HttpPost]
    [ApiSuccessResponse(StatusCodes.Status204NoContent)]
    [ApiErrorResponse(StatusCodes.Status400BadRequest, "Bad Request")]
    public async Task<IActionResult> Create([FromBody] CreateMochiCommand command, CancellationToken cancellationToken)
    {
       await Dispatcher.SendAsync(command, cancellationToken);
        return Ok();
    }
}