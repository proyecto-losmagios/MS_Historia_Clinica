
using AppHistoriaClinica.Services;
using HCTemplateDomain.DTOs;
using HCTemplateDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using MSHCAccesData;
using System;

namespace MS.HC.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HCController : ControllerBase
    {
        private readonly IHistoriasClinicasService _service;

        public HCController(IHistoriasClinicasService service)
        {
            _service = service;
        }

        [HttpGet("{paciente}")]
        public IActionResult GetHistorialClinico(string paciente)
        {
            try
            {
                return new JsonResult(_service.SearchHistoria(paciente)) { StatusCode = 201 };
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("{historia}")]
        public IActionResult GetHistorialClinico(HistoriasClinicasDto historia)
        {
            try
            {
                return new JsonResult(_service.CreateHistoriaClinica(historia)) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}