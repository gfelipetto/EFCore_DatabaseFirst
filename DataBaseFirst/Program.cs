using DataBaseFirst.Dados;
using DataBaseFirst.Extensoes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;

namespace DataBaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new CidadeContexto())
            {
                contexto.LogSQLToConsole();
                var resultado = contexto.Funcionarios.FromSqlRaw("select * from VW_ALL_FUNCIONARIOS");

                foreach (var item in resultado)
                {
                    Console.WriteLine(item);
                }
                var paramValores = new Object[]
                {
                    new SqlParameter {ParameterName = "Id", Value = Guid.NewGuid()},
                    new SqlParameter {ParameterName = "Nome", Value = "Santa Cruz"},
                    new SqlParameter {ParameterName = "Populacao", Value = 10000},
                    new SqlParameter {ParameterName = "TaxaCriminalidade", Value = 20.4f},
                    new SqlParameter {ParameterName = "ImpostoSobreProduto", Value = 5.4f},
                    new SqlParameter {ParameterName = "EstadoCalamidade", Value = false}
                };
                contexto.Database.ExecuteSqlRaw("SP_ADD_CIDADE @Id, @Nome, @Populacao, @TaxaCriminalidade," +
                    " @ImpostoSobreProduto, @EstadoCalamidade", paramValores);
            }
        }
    }
}
