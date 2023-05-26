using River.Data.IDAO;
using River.Data.Models.Domain;
using River.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.DAO
{
    public class ApplicationDAO : IApplicationDAO
    {
        public void AddApplication(Application application, RiverContext context)
        {
            context.Applications.Add(application);
        }
        public Application GetApplication(Application application, RiverContext context) {
            
            return context.Applications.Find(application.Id);
        }
        public void ChangeApplication(Application application, RiverContext context)
        {
            throw new NotImplementedException();
        }
        public void DeleteApplication(Application application, RiverContext context)
        {
            throw new NotImplementedException();
        }
    }
}
