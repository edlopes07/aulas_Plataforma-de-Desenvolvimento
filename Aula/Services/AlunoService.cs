using System;
using Aula.Models;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

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
            if (!Validar(aluno))
            {
                return false;
            }
            lista.Add(aluno);
            return true;
        }

        public bool Validar(Aluno aluno)
        {
            var context = new ValidationContext(aluno);
            var erros = new List<ValidationResult>();
            return Validator.TryValidateObject(aluno, context, erros, true);
        }
    }
}
