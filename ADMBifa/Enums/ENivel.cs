using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADMBifa.Enums
{
    public enum ENivel
    {
        [Description("Não informado")]
        NaoInformado = 0,
        [Description("Estagiario")]
        Estagiario = 1,
        [Description("Junior")]
        Junior = 2,
        [Description("Pelno")]
        Pleno = 3,
        [Description("Senior")]
        Senior = 4
    }
}
