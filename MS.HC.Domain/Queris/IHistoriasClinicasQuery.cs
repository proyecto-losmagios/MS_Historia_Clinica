using HCTemplateDomain.DTOs;
using HCTemplateDomain.Entities;
using System.Collections.Generic;

namespace AppHistoriaClinica.Services
{
    public interface IHistoriasClinicasQuery
    {

        List<HistoriasClinicasDto> SearchHistoria(string q);
        
    }
}