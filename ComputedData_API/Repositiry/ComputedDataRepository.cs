using ComputedData_API.DBContext;
using ComputedData_API.Entity;
using ComputedData_API.Interfaces;

namespace ComputedData_API.Repositiry
{
    public class ComputedDataRepository : IComputedDataRepository
    {
        private readonly AppDbContext _context;

        public ComputedDataRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddComputedDataAsync(List<WDLComputedData> data)
        {
            try
            {
                await _context.SEA_WDLComputedData.AddRangeAsync(data);

                var result = await _context.SaveChangesAsync();

                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                throw;
            }


        }
    }
}
