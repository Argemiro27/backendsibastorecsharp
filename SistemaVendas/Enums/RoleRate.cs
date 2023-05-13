using System.ComponentModel;

namespace SistemaVendas.Enums
{
    public enum RoleRate
    {
        [Description("Péssimo")]
        Terrible = 1,
        [Description("Ruim")]
        Bad = 2,
        [Description("Regular")]
        Ok = 3,
        [Description("Bom")]
        Good = 4,
        [Description("Excelente")]
        Excelent = 5,
    }
}
