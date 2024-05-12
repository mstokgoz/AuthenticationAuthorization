using AuthenticationAuthorization.Domain.Members;

namespace AuthenticationAuthorization.Application.Abstractions;

public interface IJwtProvider
{
    string Generate(Member member);
}