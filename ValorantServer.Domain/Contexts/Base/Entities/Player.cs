using ValorantServer.Domain.Shared;

namespace ValorantServer.Domain.Contexts.Base.Entities;
public class Player : BaseEntity
{
    public string UserName { get; private set; }
    public int MyProperty { get; private set; }
}