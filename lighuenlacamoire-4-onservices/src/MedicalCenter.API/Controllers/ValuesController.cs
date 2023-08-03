using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

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
        [HttpGet("CompareHeightAndWeight")]
        public string GetCompareHeightAndWeight()
        {
            return "2-3-5";
        }
        #endregion
    }
}
