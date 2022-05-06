using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.Entities.LevelOfApprovation
{
    public abstract class Spesa
    {
        public DateTime DataSpesa { get; set; }
        public string Categoria { get; set; }
        public string Descrizione { get; set; }
        public double Importo { get; set; }

       

    }
}
