using Dapper.Contrib.Extensions;

namespace ADMBifa.Models
{
    [Table("Nivel")]
    public class Nivel
    {
        public int CodigoNivel { get; set; }
        public string Descricao { get; set; }
    }
}