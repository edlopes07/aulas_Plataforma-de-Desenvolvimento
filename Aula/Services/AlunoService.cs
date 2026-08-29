using System;
using Aula.Models;
using System.Collections.Generic;
using System.Text;

namespace Aula.Services
{
    internal class AlunoService
    {
        private List<Aluno> lista = new List<Aluno>();

        public List<Aluno> Consultar()
        {
            return lista.ToList();
        }

        public bool Criar(Aluno aluno)
        {
            lista.Add(aluno);
            return true;
        }
    }
}
