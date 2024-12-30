using ComputedData_API.Interfaces;
using ComputedData_API.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ComputedData_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WDLComputedDataController : ControllerBase
    {

        private readonly IComputedDataService _computedDataService;

        public WDLComputedDataController(IComputedDataService computedDataService)
        {
            _computedDataService = computedDataService;
        }

        [HttpPost]
        [Route("AddComputedDataAsync")]

        public async Task<IActionResult> Post([FromBody] List<WDLComputedDataModel> wDLComputedDataModels)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return StatusCode(StatusCodes.Status400BadRequest, ModelState);
                }
                // If you want to pass a single LearnerModel object to the method, you need to wrap it in a list:

                var computedDataModels = await _computedDataService.AddComputedDataAsync(wDLComputedDataModels);

                //return StatusCode(StatusCodes.Status201Created, "computedDataModels Details Added Succesfully");

                return Ok(computedDataModels);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "System or Server Error");
            }

        }
    }
}
