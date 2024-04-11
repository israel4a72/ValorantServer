using ValorantServer.Domain.Contexts.Base.Entities;
using ValorantServer.Domain.Exceptions;
using ValorantServer.Domain.Shared;

namespace ValorantServer.Domain.Contexts.Social.Entities;
public class Squad : BaseEntity
{
    public IEnumerable<Player> Players { get; private set; }

    public Squad(Guid id, IEnumerable<Player> players) : base(id)
    {
        if (players is null)
            throw new DomainException("Players cannot be null.");
        if (players.Count() > 5)
            throw new DomainException("A squad can have a maximum of 5 players.");
        if (players.Count() < 1)
            throw new DomainException("A squad must have at least 1 player.");

        Players = players;
    }
}