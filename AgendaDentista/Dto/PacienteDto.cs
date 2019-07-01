using AgendaDentista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDentista.Dto
{
    public class PacienteDto
    {

        public IEnumerable<Paciente> Pacientes { get; set; }
        public Paciente Paciente { get; set; }

    }
}
