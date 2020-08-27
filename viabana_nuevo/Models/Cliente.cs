namespace viabana_nuevo.Models
{
    public class Cliente: Persona
    {
        public string Cuit { get; set; }
        public TipoCliente TipoCliente { get; set; }
    }
}