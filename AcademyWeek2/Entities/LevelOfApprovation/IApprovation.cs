using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyWeek2.Entities.LevelOfApprovation
{
    public interface IApprovation
    {
        IApprovation SetNext(IApprovation approve);

        string Approvation(double request);
    }
}
