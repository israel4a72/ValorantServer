namespace ValorantServer.Domain.Shared
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public BaseEntity(Guid id)
        {
            Id = id;
        }
    }
}