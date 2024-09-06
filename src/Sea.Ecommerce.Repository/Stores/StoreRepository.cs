using Microsoft.EntityFrameworkCore;
using Sea.Ecommerce.Repository.Helper;
using Sea.Ecommerce.Repository.Models;

namespace Sea.Ecommerce.Repository.Stores
{
    public class StoreRepository : IStoreRepository
    {
        private readonly StoreDbContext _storeContext;

        public StoreRepository(StoreDbContext storeContext)
        {
            _storeContext = storeContext;
        }

        public async Task<Store?> GetByIdAsync(Guid id)
        {
            return await _storeContext.Stores.FirstOrDefaultAsync(store => store.Id == id);
        }

        public async Task<IEnumerable<Store>> GetAllAsync()
        {
            return await _storeContext.Stores.ToListAsync();
        }

        public async Task AddAsync(Store store)
        {
            _storeContext.Stores.Add(store);
            await _storeContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(Store store)
        {
            _storeContext.Stores.Remove(store);
            await _storeContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Store store)
        {
            _storeContext.Stores.Update(store);
            await _storeContext.SaveChangesAsync();
        }

        public IEnumerable<Store> GetAllMockAsync()
        {
            return StoreMock.GetMockStores();
        }
    }
}
