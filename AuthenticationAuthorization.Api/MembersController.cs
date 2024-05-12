using System.Security.Claims;
using AuthenticationAuthorization.Application.Features.Members.LoginCommandHandler;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.JsonWebTokens;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace AuthenticationAuthorization.Api;

[Route("api/[controller]")]
[ApiController]
public class MembersController : Controller
{
    private readonly IMediator _mediator;

    public MembersController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> LoginMember([FromBody] LoginCommandRequest request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);

        return StatusCode(result.StatusCode, result.AccessToken);
    }

    [Authorize]
    [HttpGet]
    public async Task<IActionResult> GetMember()
    {
        var test = User;

        var claims = User.Claims.ToList();

        var userId = User.Claims.FirstOrDefault(c => c.Type == JwtRegisteredClaimNames.Sub)?.Value;
        
        var userId2 = User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        
        return Ok();
    }
}