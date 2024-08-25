using Microsoft.AspNetCore.Mvc;
using Sea.Ecommerce.Service.Stores;

namespace Sea.Ecommerce.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        private readonly ILogger<StoreController> _logger;

        public StoreController(IStoreService storeService, ILogger<StoreController> logger)
        {
            _storeService = storeService;
            _logger = logger;
        }

        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var idLog = Guid.NewGuid();

            _logger.LogDebug($"Log Debug Getall Id:{idLog}");
            _logger.LogInformation($"Log Information Getall Id:{idLog}");
            _logger.LogWarning($"Log Warning Getall Id:{idLog}");
            _logger.LogError($"Log Error Getall Id:{idLog}");
            _logger.LogCritical($"Log Critical Getall Id:{idLog}");

            return Ok(await _storeService.GetAllAsync());
        }
    }
}
