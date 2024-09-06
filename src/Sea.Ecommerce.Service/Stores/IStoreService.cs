using Sea.Ecommerce.Service.Stores.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea.Ecommerce.Service.Stores
{
    public interface IStoreService
    {
        Task<ICollection<StoreResult>> GetAllAsync();

        ICollection<StoreResult> GetAllMockAsync();
    }
}
