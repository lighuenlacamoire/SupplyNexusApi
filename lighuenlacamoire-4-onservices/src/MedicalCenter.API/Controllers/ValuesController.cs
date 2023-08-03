using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalCenter.Domain.Support.Helpers;

namespace MedicalCenter.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        #region Dependencias
        private readonly ILogger<ValuesController> _logger;
        #endregion

        #region Constructor
        public ValuesController(
            ILogger<ValuesController> logger)
        {
            this._logger = logger;
        }
        #endregion

        #region Endpoints
        [HttpPost("CompareHeightAndWeight")]
        public async Task<IActionResult> UploadCompareHeightAndWeight(IFormFile file)
        {
            if(file != null)
            {
                string nose = await file.ReadAsStringAsync();
                return Ok(nose);
            }
            return Ok("2-3-5");
        }
        #endregion
    }
}
