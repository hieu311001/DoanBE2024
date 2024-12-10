using Microsoft.AspNetCore.Mvc;
using ProductOrder.Entities;
using ProductOrder.Parameters;

namespace ProductOrder.Services.Interfaces
{
    public interface IStoreService : IBaseService<StoreEntity>
    {
        dynamic GetStorageReport(ReportProductParam param);
        dynamic GetStoreReport(ReportProductParam param);
    }
}
