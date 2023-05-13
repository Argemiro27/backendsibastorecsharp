using System.ComponentModel;

namespace SistemaVendas.Enums
{
    public enum RoleFormaPagamento
    {
        [Description("À vista")]
        Avista = 1,
        [Description("Parcelado")]
        Parcelado = 2,
    }
}
