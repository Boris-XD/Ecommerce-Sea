using Microsoft.AspNetCore.Mvc;
using Sea.Ecommerce.Service.Stores;

namespace Sea.Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;

        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _storeService.GetAllAsync());
        }
    }
}
