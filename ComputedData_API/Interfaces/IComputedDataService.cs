using ComputedData_API.Model;

namespace ComputedData_API.Interfaces
{
    public interface IComputedDataService
    {
        Task<bool> AddComputedDataAsync(List<WDLComputedDataModel> dataModels);
    }
}
