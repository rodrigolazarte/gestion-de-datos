namespace viabana_nuevo.Models
{
    public class Novedad
    {
        public int Id { get; set; }
        public TipoNovedad TipoNovedad { get; set; }
        public string Descripcion { get; set; }
        public int MontoNovedad { get; set; }

    }
}