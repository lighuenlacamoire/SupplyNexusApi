using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Palindromo.API.Support.Helpers;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Palindromo.API.Controllers
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
        [SwaggerOperation(Summary = "Devuelve si el texto es palindromo o no y distintas codificaciones")]
        [HttpGet("IsPalindrome")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Dictionary<string, string>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Exception))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        public async Task<IActionResult> GetIsPalindrome(string value)
        {
            var result = new Dictionary<string, string> 
            {
                { "IsPalindrome", "No es palíndromo" },
                { "UTF8", "" },
                { "ISO-8859-1", "" }
            };

            if(!string.IsNullOrEmpty(value))
            {
                string newValue = value.NormalizeFormat();
                char[] compare = newValue.ToCharArray();
                Array.Reverse(compare);

                string reverseValue = new string(compare);

                if(newValue.Equals(reverseValue, StringComparison.InvariantCultureIgnoreCase))
                {
                    result["IsPalindrome"] = "Es palíndromo";
                }

                Encoding iso = Encoding.Latin1;
                Encoding utf8 = Encoding.UTF8;

                byte[] bytes = Encoding.Default.GetBytes(value);

                result["UTF8"] = utf8.GetString(bytes);
                result["ISO-8859-1"] = iso.GetString(bytes);
            }

            return Ok(result);
        }
        #endregion
    }
}
