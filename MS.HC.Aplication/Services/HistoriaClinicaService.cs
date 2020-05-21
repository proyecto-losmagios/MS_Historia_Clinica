using System;
using System.Collections.Generic;
using HCTemplateDomain.Entities;
using HCTemplateDomain.DTOs;
using MS.HC.Domain.Commands;

namespace AppHistoriaClinica.Services
{

    public interface IHistoriasClinicasService
    {
        HistoriasClinicas HistoriaClinica(HistoriasClinicasDto historias);
        List<HistoriasClinicasDto> SearchHistoria(string q);
    }

    public class HistoriasClinicasServices : IHistoriasClinicasService
    {

        private readonly IGenericsRepository _repository;
        private readonly IHistoriasClinicasQuery _query;

        public HistoriasClinicasServices(IGenericsRepository repository, IHistoriasClinicasQuery query)
        {
            _repository = repository;
            _query = query;

        }

        public HistoriasClinicas CreateMedico(HistoriasClinicasDto historias)
        {
            var entity = new HistoriasClinicas
            {
                HistoriaClinicaId = historias.HistoriaClinica_id,
                PacienteId = historias.Paciente_id,
                MedicoId = historias.Medico_id,
                FechaConsulta = historias.FechaConsulta,
                TurnoId = historias.Turno_id,
                DetalleDeConsulta = historias.DetalleDeConsulta,

            };

            _repository.Add<HistoriasClinicas>(entity);

            return entity;
        }

        public List<HistoriasClinicas> SearchMedico(string q)
        {
            return _query.SearchHistoria(q);
        }

        HistoriasClinicas IHistoriasClinicasService.HistoriaClinica(HistoriasClinicasDto historias)
        {
            throw new NotImplementedException();
        }

        List<HistoriasClinicasDto> IHistoriasClinicasService.SearchHistoria(string q)
        {
            throw new NotImplementedException();
        }
    }
}
