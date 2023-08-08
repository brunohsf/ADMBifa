using System;
using ADMBifa.Enums;
using Dapper.Contrib.Extensions;

namespace ADMBifa.Models
{
    [Table("Colaborador")]
    public class Colaborador
    {
        public Colaborador(int codigoColaborador, string nome, DateTime dataContratacao, int limiteBifa, ENivel nivel, bool ativo)
        {
            CodigoColaborador = codigoColaborador;
            Nome = nome;
            DataContratacao = dataContratacao;
            LimiteBifas = limiteBifa;
            CodigoNivel = nivel;
            Ativo = ativo;
        }

        public Colaborador()
        {

        }

        [Key]
        public int CodigoColaborador { get; set; }
        public string Nome { get; set; }
        public DateTime DataContratacao { get; set; }
        public int LimiteBifas { get; set; }
        public ENivel CodigoNivel { get; set; }
        public bool Ativo { get; set; }

    }
}
