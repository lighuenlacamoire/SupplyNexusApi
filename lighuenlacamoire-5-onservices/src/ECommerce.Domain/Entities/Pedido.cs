using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Domain.Entities
{
    [Table(name: "PEDIDOS")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("ID")]
        public int Id { get; set; }

        #region FK - Tienda
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [ForeignKey(name: "TIENDA_ID")]
        [Column("TIENDA_ID")]
        public int TiendaId { get; set; }
        public Tienda Tienda { get; set; }
        #endregion

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Column("SHIPMENT_ID")]
        public string ShipmentId { get; set; }

        [Column("FECHA_ENTREGA")]
        public DateTime FechaDeEntrega { get; set; }

        [Column("ESTADO_MAYOR")]
        public int EstadoMayor { get; set; }

        [Column("ESTADO_MENOR")]
        public int EstadoMenor { get; set; }
    }
}
