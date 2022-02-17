using System.Collections.Generic;

namespace MaxionMontichV2.Models
{
    public class Planta
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public List<TablerosElectricos> TablerosElec { get; set; }
        public List<HyM> HyM { get; set; }
        public List<Elevadores> Elevadores { get; set; }

    }

}
