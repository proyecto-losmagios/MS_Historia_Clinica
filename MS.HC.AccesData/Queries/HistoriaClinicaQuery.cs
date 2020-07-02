using AppHistoriaClinica.Services;
using HCTemplateDomain.DTOs;
using HCTemplateDomain.Entities;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;



namespace MS.HC.AccesData.Queries
{
    public class HistoriaClinicaQuery : IHistoriasClinicasQuery
    {
        private readonly IDbConnection _connection;
        private readonly Compiler _sqlKataCompiler;

        public HistoriaClinicaQuery(IDbConnection connection, Compiler sqlKataCompiler)
        {
            _connection = connection;
            _sqlKataCompiler = sqlKataCompiler;
        }

       

        public List<HistoriasClinicasDto> SearchHistoria(string q)
        {
            var db = new QueryFactory(_connection, _sqlKataCompiler);

            var historia = db.Query("HistoriaClinicas")
                .Select("HistoriaClinicaId", "PacienteId", "MedicoId")
                .Where("PacienteId", "=", q).Get<HistoriasClinicasDto>();
            var result = historia.ToList();
            return result;
        }
    }
}
