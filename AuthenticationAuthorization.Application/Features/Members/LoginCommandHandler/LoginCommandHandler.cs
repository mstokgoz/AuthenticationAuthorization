using AuthenticationAuthorization.Application.Abstractions;
using AuthenticationAuthorization.Domain.Members;
using MediatR;

namespace AuthenticationAuthorization.Application.Features.Members.LoginCommandHandler;

public class LoginCommandHandler : IRequestHandler<LoginCommandRequest, LoginCommandResponse>
{
    private readonly IJwtProvider _jwtProvider;

    public LoginCommandHandler(IJwtProvider jwtProvider)
    {
        _jwtProvider = jwtProvider;
    }

    public async Task<LoginCommandResponse> Handle(LoginCommandRequest request, CancellationToken cancellationToken)
    {
        // var member = _memberRepository.GetByEmailAsync(request.Email);

        var member = new Member { Email = "serkantokgoz09@gmail.com", HashedPassword = "123456", Id = new Guid() };

        var accessToken = _jwtProvider.Generate(member);

        return new LoginCommandResponse
        {
            AccessToken = accessToken
        };
    }
}