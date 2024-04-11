using ValorantServer.Domain.Shared;

namespace ValorantServer.Domain.Contexts.Base.Entities;
public class Player : BaseEntity
{
    public string UserName { get; private set; }
    public string Email { get; private set; }

    public Player(Guid id, string userName, string email) : base(id)
    {
        UserName = userName;
        Email = email;
    }
}