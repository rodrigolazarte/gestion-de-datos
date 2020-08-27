namespace viabana_nuevo.Models
{
    public class Concepto
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public float Valor { get; set; }
        public Enumeraciones.TipoConcepto TipoConcepto { get; set; }
        public Enumeraciones.Unidad Unidad { get; set; }
        public Enumeraciones.Efecto Efecto { get; set; }


    }
}