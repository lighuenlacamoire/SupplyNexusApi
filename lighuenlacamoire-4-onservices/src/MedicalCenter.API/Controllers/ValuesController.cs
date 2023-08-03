using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using MedicalCenter.Domain.Support.Helpers;
using System.IO;
using System.Linq;
using System.ComponentModel.DataAnnotations;

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
        public async Task<IActionResult> UploadCompareHeightAndWeight([Required]IFormFile file)
        {
            if (file != null)
            {
                List<string> result = new List<string>();
                var list = await file.ReadAsPairNumbersListAsync();

                for (int i = 1;i < list.Count; i++)
                {
                    var prevItem = list.ElementAt(i - 1);
                    var currentItem = list.ElementAt(i);

                    if(currentItem.Value.Key > prevItem.Value.Key
                        && currentItem.Value.Value > prevItem.Value.Value)
                    {
                        result.Add(currentItem.Key.ToString());
                    }
                }

                return Ok(string.Join("-", result));
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        #endregion
    }
}
