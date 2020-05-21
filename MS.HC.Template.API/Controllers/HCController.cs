
using HCTemplateDomain.DTOs;
using HCTemplateDomain.Entities;
using Microsoft.AspNetCore.Mvc;
using MSHCAccesData;

namespace MS.HC.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HCController : ControllerBase
    {
        private readonly HCTemplateContext _context;

        public HCController(HCTemplateContext context)
        {
            _context = context;
        }
    }
}