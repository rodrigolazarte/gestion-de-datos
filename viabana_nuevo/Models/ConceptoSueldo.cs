namespace viabana_nuevo.Models
{
    public class ConceptoSueldo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string TipoConcepto { get; set; }
        public string UnidadConcepto { get; set; }
        public double Monto { get; set; }
    }
}