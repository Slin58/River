using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using River.Data.Models.Domain;
using River.Data.Models.Repository;
using River.Data.Models.Repository;

namespace River.Services.IService
{
    public interface IUniversityService
    {
        IList<University> GetUniversities();
        University GetUniversity(string name);
        University GetUniversity(int id);

        void AddUniversity(University university, int universityId, string name, ICollection<Application> applications);

        void AddToCollection(Application application, University university, RiverContext context);
        List<Application> GetApplications(int id);
    }
}
