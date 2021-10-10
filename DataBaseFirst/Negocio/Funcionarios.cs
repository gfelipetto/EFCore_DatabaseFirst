using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBaseFirst.Negocio
{
    public class Funcionarios
    {     
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid CidadeId { get; set; }
        public Cidades CidadeTrabalho { get; set; }
        public IList<FuncoesFuncionarios> FuncoesMembro { get; set; }
        public Funcionarios()
        {
            FuncoesMembro = new List<FuncoesFuncionarios>();
        }

        public override string ToString()
        {
            return $"{Nome} - {DataNascimento}";
        }
    }
}
