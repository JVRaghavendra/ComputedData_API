using ComputedData_API.Entity;

namespace ComputedData_API.Interfaces
{
    public interface IComputedDataRepository
    {
        Task<bool> AddComputedDataAsync(List<WDLComputedData> data);
    }
}
