using ECommerce.Domain.DTOs;
using ECommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Services.Interfaces
{
    public interface ITiendaService
    {
        List<EntregaDTO> GetAllEntregas();
    }
}
