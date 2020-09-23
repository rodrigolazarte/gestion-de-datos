using System.ComponentModel.DataAnnotations;

namespace viabana_nuevo.Models
{
    public class Cliente
    {
        [Key]
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public TipoCliente TipoCliente { get; set; }
    }
}