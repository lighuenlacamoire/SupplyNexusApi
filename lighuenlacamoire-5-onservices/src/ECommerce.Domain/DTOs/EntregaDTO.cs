using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerce.Domain.DTOs
{
    public class EntregaDTO
    {
        [JsonPropertyName("TIENDA")]
        public string TiendaNombre { get; set; }

        [JsonPropertyName("FECHA ENTREGA")]
        public DateTime FechaEntrega { get; set; }

        [JsonPropertyName("Nº PEDIDOS")]
        public int CantPedidos { get; set; }
    }
}
