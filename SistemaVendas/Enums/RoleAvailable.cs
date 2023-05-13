using System.ComponentModel;

namespace SistemaVendas.Enums
{
    public enum RoleUsuario
    {
        [Description("Disponível")]
        Available = 1, 
        [Description("Indisponível")]
        Unavailable = 2,
    }
}
