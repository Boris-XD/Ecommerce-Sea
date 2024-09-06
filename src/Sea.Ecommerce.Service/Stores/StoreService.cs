using AutoMapper;
using Sea.Ecommerce.Repository.Stores;
using Sea.Ecommerce.Service.Stores.Dto;

namespace Sea.Ecommerce.Service.Stores
{
    public class StoreService : IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IMapper _mapper;

        public StoreService(IStoreRepository storeRepository, IMapper mapper)
        {
            _storeRepository = storeRepository;
            _mapper = mapper;
        }

        public async Task<ICollection<StoreResult>> GetAllAsync()
        {
            var result  = await _storeRepository.GetAllAsync();

            return _mapper.Map<ICollection<StoreResult>>(result);
        }

        public ICollection<StoreResult> GetAllMockAsync()
        {
            var result = _storeRepository.GetAllMockAsync();

            return _mapper.Map<ICollection<StoreResult>>(result);
        }
    }
}
