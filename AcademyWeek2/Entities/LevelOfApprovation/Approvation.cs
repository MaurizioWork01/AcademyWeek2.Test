using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.Entities.LevelOfApprovation
{
    public class Approvation
    {
        public static string ApprovationCode(AbstractApprove aa, double richiesta)
        {

            var result = aa.Approvation(richiesta);

            if (result != null)
            {
                return result;
            }
            else
            {
                return null;
            }

            
        }

    }
}
