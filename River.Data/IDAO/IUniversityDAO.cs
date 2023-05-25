using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using River.Data.Models.Domain;
using River.Data.Models.Repository;

namespace River.Data.IDAO
{
    public interface IUniversityDAO
    {
        IList<University> GetUniversities(RiverContext context);
        University GetUniversity(int id, RiverContext context);

        void AddUniversity(University university, int universityId, string name, ICollection<Application> applications);
    }
}
