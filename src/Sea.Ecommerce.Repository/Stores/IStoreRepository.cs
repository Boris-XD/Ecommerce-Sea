using Sea.Ecommerce.Repository.Models;

namespace Sea.Ecommerce.Repository.Stores
{
    public interface IStoreRepository
    {
        Task<Store> GetByIdAsync(Guid id);
        Task<IEnumerable<Store>> GetAllAsync();
        IEnumerable<Store> GetAllMockAsync();
        Task AddAsync(Store store);
        Task RemoveAsync(Store store);
        Task UpdateAsync(Store store);
    }
}
