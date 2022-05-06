using AcademyWeek2.Entities.LevelOfApprovation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.LevelOfApprovation
{
    public class CEO : AbstractApprove
    {
        public override string Approvation(double request)
        {
            if (request >1000 && request <2500)
            {
                return "CEO";
            }
            else
            {
                return base.Approvation(request);
            }
        }   
    }
}
