using ECommerce.Domain.Entities;
using ECommerce.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;

namespace ECommerce.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TiendaController : ControllerBase
    {
        #region Dependencias
        private readonly ITiendaService _tiendaService;
        #endregion

        #region Constructor
        public TiendaController(
            ITiendaService tiendaService
            )
        {
            this._tiendaService = tiendaService;
        }
        #endregion

        #region Endpoints
        [SwaggerOperation(Summary = "Obtiene el listado de tiendas y pedidos")]
        [HttpGet("Entregas")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Pedido>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(Exception))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(Exception))]
        public async Task<IActionResult> GetAllEntregas()
        {
            var response = _tiendaService.GetAllEntregas();
            return Ok(response);
        }
        #endregion
    }
}
