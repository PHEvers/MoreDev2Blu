using System.ComponentModel;

namespace Registration_System.Models.Enum
{
    public enum Fl_Status
    {
        [Description("Excluido")]
        E = 0,
        [Description("Ativo")]
        A = 1,
        [Description("Inativo")]
        I = 2
    }
}