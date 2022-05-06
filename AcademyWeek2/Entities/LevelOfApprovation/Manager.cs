using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.Entities.LevelOfApprovation
{
    public class Manager : AbstractApprove
    {
        public override string Approvation(double request)
        {
            if (request>0 && request <=400)
            {
                return "Manager";
            }
            else
            {
                return base.Approvation(request);
            }
        }

    }
}
