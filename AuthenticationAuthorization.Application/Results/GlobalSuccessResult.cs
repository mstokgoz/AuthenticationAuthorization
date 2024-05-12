using System.Net;

namespace AuthenticationAuthorization.Application.Results;

public class GlobalSuccessResult
{
    public int StatusCode { get; set; } = (int)HttpStatusCode.OK;
}