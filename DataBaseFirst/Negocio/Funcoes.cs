using System;
using System.Collections.Generic;

namespace DataBaseFirst.Negocio
{
    public class Funcoes
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public int NivelAcesso { get; set; }
        public IList<FuncoesFuncionarios> MembrosFuncao { get; set; }
        public Funcoes()
        {
            MembrosFuncao = new List<FuncoesFuncionarios>();
        }
    }
}
