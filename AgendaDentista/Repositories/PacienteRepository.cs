using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaDentista.Context;
using AgendaDentista.Models;

namespace AgendaDentista.Repositories
{
    public class PacienteRepository : IPacienteRepository
    {
        private readonly AppDbContext _contexto;

        public PacienteRepository(AppDbContext contexto)
        {
            _contexto = contexto;
        }
        public IEnumerable<Paciente> Pacientes => _contexto.Pacientes;

        public void Adicionar(Paciente paciente)
        {
            _contexto.Add(paciente);
            _contexto.SaveChanges();
        }

        public void Deletar(int id)
        {
            var paciente = _contexto.Pacientes.FirstOrDefault(p => p.PacienteID == id);
            _contexto.Pacientes.Remove(paciente);
            _contexto.SaveChanges();
        }
    }
}
