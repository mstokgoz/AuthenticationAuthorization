using AuthenticationAuthorization.Application.Results;

namespace AuthenticationAuthorization.Application.Features.Members.LoginCommandHandler;

public class LoginCommandResponse : GlobalSuccessResult
{
    public string AccessToken { get; set; }
}