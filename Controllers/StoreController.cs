using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductOrder.Entities;
using ProductOrder.Parameters;
using ProductOrder.Services.Interfaces;

namespace ProductOrder.Controllers
{
    [ApiController]
    public class StoreController : BaseController<StoreEntity, IStoreService>
    {
        public StoreController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        /// <summary>
        /// Lấy toàn bộ sản phẩm
        /// </summary>
        [HttpPost("get-report")]
        public IActionResult GetStoreReport([FromBody] ReportProductParam param)
        {
            dynamic result = _service.GetStoreReport(param);
            return Ok(result);
        }

        /// <summary>
        /// Lấy toàn bộ sản phẩm
        /// </summary>
        [HttpPost("get-report-storage")]
        public IActionResult GetStorageReport([FromBody] ReportProductParam param)
        {
            dynamic result = _service.GetStorageReport(param);
            return Ok(result);
        }
    }
}
