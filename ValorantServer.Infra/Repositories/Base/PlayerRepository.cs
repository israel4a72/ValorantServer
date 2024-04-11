using ValorantServer.Domain.Contexts.Base.Entities;

namespace ValorantServer.Infra.Repositories.Base
{
    public class PlayerRepository : BaseRepository<Player>
    {
        public PlayerRepository()
        {
            Entities =
            [
                new Player(new Guid("6d373258-f84e-4420-a243-310c9fd685c3"), "Player 1", "a@b.c"),
                new Player(new Guid("afefbd0b-9003-42f9-abac-3df1a8133ec5"), "Player 2", "d@e.f"),
                new Player(new Guid("58500fc8-92ee-416b-83e0-c733faaced40"), "Player 3", "g@h.i"),
            ];
        }
    }
}