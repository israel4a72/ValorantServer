using ValorantServer.Domain.Shared;

namespace ValorantServer.Infra.Repositories
{
    public abstract class BaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected IEnumerable<TEntity> Entities { get; set; }
        public BaseRepository()
        {
            Entities = [];
        }
        public async Task<TEntity?> GetByIdAsync(Guid id)
        {
            await Task.CompletedTask;

            return Entities.FirstOrDefault(e => e.Id == id);
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            await Task.CompletedTask;

            return Entities;
        }
        public async Task AddAsync(TEntity entity)
        {
            await Task.CompletedTask;
        }
        public async Task UpdateAsync(TEntity entityToUpdate)
        {
            await Task.CompletedTask;
            Entities = Entities.Select(e => e.Id == entityToUpdate.Id ? entityToUpdate : e).ToList();
        }
        public async Task DeleteAsync(Guid id)
        {
            await Task.CompletedTask;

            Entities = Entities.Where(e => e.Id != id).ToList();
        }
    }
}