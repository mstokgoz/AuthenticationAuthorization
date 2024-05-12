using MediatR;

namespace AuthenticationAuthorization.Application.Features.Members.LoginCommandHandler;

public class LoginCommandRequest : IRequest<LoginCommandResponse>
{
    public string Email { get; set; }

    public string Password { get; set; }
}