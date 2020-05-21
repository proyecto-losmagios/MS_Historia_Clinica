using HCTemplateDomain.DTOs;
using HCTemplateDomain.Entities;
using System.Collections.Generic;

namespace AppHistoriaClinica.Services
{
    public interface IHistoriasClinicasQuery
    {


        public interface IHistoriasClinicasQuery
        {
        }

        List<HistoriasClinicas> SearchHistoria(string q);
    }
}