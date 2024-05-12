namespace AuthenticationAuthorization.Domain.Members;

public class Member
{
    public Guid Id { get; set; }

    public string Email { get; set; }

    public string HashedPassword { get; set; }
    
}