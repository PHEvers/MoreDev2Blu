using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Models.Enum
{
    public enum TipoPessoa
    {
        [Description("Pessoa Física")]
        PF = 0,
        [Description("Pessoa Jurídica")]
        PJ = 1,
    }
}
