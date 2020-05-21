using System;
using System.Collections.Generic;
using System.Text;

namespace HCTemplateDomain.DTOs
{
    public class HistoriasClinicasDto
    {
        public Guid HistoriaClinica_id { get; set; }
        public Guid Paciente_id { get; set; }
        public Guid Medico_id { get; set; }
        public DateTime FechaConsulta = new DateTime();
        public Guid Turno_id { get; set; }
        public string DetalleDeConsulta { get; set; }
    }
}
