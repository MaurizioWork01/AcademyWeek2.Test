using AcademyWeek2.Entities.LevelOfApprovation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2
{
   public class Reader
    {
        public List<Spesa> ReadFile(string percorso)
        {

            StreamReader sr = new StreamReader(percorso);
            string riga = "";
            List<Spesa> list = new List<Spesa>();
            
            do
            {
                riga = sr.ReadLine();
                var rigaSplittata = riga.Split(";");

                


            } while (sr.EndOfStream);
            return list;
        }

    }
}
