using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Calculator.API.Controllers
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
        [SwaggerOperation(Summary = "Obtiene el listado de numeros armstrong")]
        [HttpGet("ArmstrongNumbers")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<int>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Exception))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        public async Task<IActionResult> GetArmstrongNumbers()
        {
            List<int> result = new List<int>();
            // val = variable/digito a multiplicar (a o b o c)
            // sum = suma acumulada de "val" multiplicada (a*a*a+b*b*b+c*c*c)
            // temporaryValue = numero temporal que se prueba (100, 101, 102, n...)
            int val, sum, temporaryValue;
            for (int number = 100; number <= 999; number++)
            {
                temporaryValue = number;
                sum = 0;
                while (temporaryValue != 0)
                {
                    val = temporaryValue % 10;
                    temporaryValue = temporaryValue / 10;
                    sum = sum + (val * val * val);
                }
                // si la sumatoria acumulada es igual al number de prueba
                //... entonces obtuvimos el valor correcto
                if (sum == number)
                {
                    result.Add(number);
                }
            }
            return Ok(result);
        }
        #endregion
    }
}
