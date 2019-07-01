using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaDentista.Dto;
using AgendaDentista.Models;
using AgendaDentista.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AgendaDentista.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PacienteController : Controller
    {
        private readonly IPacienteRepository _pacienteRep;

        public PacienteController(IPacienteRepository pacienteRepository)
        {
            _pacienteRep = pacienteRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var viewResult = _pacienteRep.Pacientes;
            return Ok(viewResult);
        }


        [HttpPost]
        public IActionResult Post([FromBody] Paciente paciente)
        {
            var p = new Paciente()
            {
                Nome = paciente.Nome,
                Telefone = paciente.Telefone,
                Email = paciente.Email
            };

            _pacienteRep.Adicionar(p);

            return RedirectToAction("Get");
        }

    }
}