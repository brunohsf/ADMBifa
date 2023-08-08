using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMBifa.Models
{
    [Table("Nivel")]
    public class Nivel
    {
        public int CodigoNivel { get; set; }
        public string Descricao { get; set; }
    }
}
