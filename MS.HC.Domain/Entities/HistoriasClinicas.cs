using System;
using System.Collections.Generic;
using System.Text;

namespace HCTemplateDomain.Entities
{
    public class HistoriasClinicas
    {
       
        public Guid HistoriaClinica_id { get; set; }
        public Guid Paciente_id { get; set; }
        public Guid Medico_id { get; set; }
        public DateTime FechaConsulta = new DateTime();
        public Guid Turno_id { get; set; }
        public String DetalleDeConsulta { get; set; }
    }
}
