using ComputedData_API.Entity;
using ComputedData_API.Interfaces;
using ComputedData_API.Model;

namespace ComputedData_API.Service
{
    public class ComputedDataService : IComputedDataService
    {
        private readonly IComputedDataRepository _repository;

        public ComputedDataService(IComputedDataRepository repository)
        {
            _repository = repository;

        }
        public async Task<bool> AddComputedDataAsync(List<WDLComputedDataModel> dataModels)
        {

            try 
            {
                
            var entities = new List<WDLComputedData>();

            foreach (var model in dataModels)
            {
                var entity = new WDLComputedData();
                {
                    entity.ID = model.ID;
                    entity.EmployeeID = model.EmployeeID;
                    entity.SkillID = model.SkillID;
                    entity.StartDate = model.StartDate;
                    entity.EndDate = model.EndDate;
                    entity.UsagePercentage = model.UsagePercentage;
                    entity.SourceSystem = model.SourceSystem;
                    entity.CourseID = model.CourseID;
                    entity.CourseName = model.CourseName;
                    entity.CreatedDateTime = DateTimeOffset.UtcNow;
                    entity.ProcessedDateTime = null;
                    entity.IsProcessed = false;

                    entities.Add(entity);

                }
            }
                  var result = await _repository.AddComputedDataAsync(entities);

                  return result;
            }

             catch (Exception ex)
            {
                throw;
            }
        }
    }
}
