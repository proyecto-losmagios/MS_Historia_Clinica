using System;
using System.Collections.Generic;
using System.Text;

namespace HCTemplateDomain.Entities
{
    public class HistoriasClinicas
    {
       
        public Guid HistoriaClinicaId { get; set; }
        public Guid PacienteId { get; set; }
        public Guid MedicoId { get; set; }
        public DateTime FechaConsulta = new DateTime();
        public Guid TurnoId { get; set; }
        public String DetalleDeConsulta { get; set; }
    }
}
