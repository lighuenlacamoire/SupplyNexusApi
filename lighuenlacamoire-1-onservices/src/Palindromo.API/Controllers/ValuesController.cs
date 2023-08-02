using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Palindromo.API.Support.Helpers;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Palindromo.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;

        public ValuesController(
            ILogger<ValuesController> logger)
        {
            this._logger = logger;
        }

        [HttpGet("IsPalindrome")]
        public Dictionary<string, string> GetIsPalindrome(string value)
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

            return result;
        }

    }
}
