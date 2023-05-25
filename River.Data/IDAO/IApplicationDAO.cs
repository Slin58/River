using River.Data.Models.Domain;
using River.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.IDAO
{
    public interface IApplicationDAO
    {
        void AddApplication(Application application, RiverContext context);
        Application GetApplication(Application application, RiverContext context);
        void ChangeApplication(Application application, RiverContext context);
        void DeleteApplication( Application application, RiverContext context);

    }
}
