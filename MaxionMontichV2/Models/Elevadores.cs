namespace MaxionMontichV2.Models
{
    public class Elevadores
    {
        public int Id { get; set; }
        public int PlantaId { get; set; }
        public string Codigo { get; set; }
        public Planta planta { get; set; }
    }
}
