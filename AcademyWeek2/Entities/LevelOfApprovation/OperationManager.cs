using AcademyWeek2.Entities.LevelOfApprovation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.LevelOfApprovation
{
    public class OperationManager : AbstractApprove
    {
        public override string Approvation(double request)
        {
            if (request >= 401 && request < 1000)
            {
                return "Operation Manager";
            }
            else
            {
                return base.Approvation(request);
            }
        }       
    }
}
