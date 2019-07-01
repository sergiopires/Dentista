using AgendaDentista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaDentista.Repositories
{
    public interface IPacienteRepository
    {
        IEnumerable<Paciente> Pacientes { get; }
        void Adicionar(Paciente paciente);
        void Deletar(int id);
    }
}
