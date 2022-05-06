using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.Entities.LevelOfApprovation
{
    public abstract class AbstractApprove : IApprovation
    {
        private IApprovation nextApprovation;
        public virtual string Approvation(double request)
        {
            if ( nextApprovation != null)
            {
                return nextApprovation.Approvation(request);
            }
            else
            {
                return null;
            }
        }

        public IApprovation SetNext(IApprovation approve)
        {
            nextApprovation = approve;
            return approve;
        }
    }
}
