using River.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using River.Data.Models.Domain;
using River.Data.Models.Repository;
using River.Data.IDAO;
using River.Data.DAO;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace River.Services.Service
{

    public class UniversityService : IUniversityService
    {
        IUniversityDAO universityDAO;

        public UniversityService()
        {
            universityDAO = new UniversityDAO();
        }
        public IList<University> GetUniversities()
        {
            using (RiverContext context = new RiverContext())
                return universityDAO.GetUniversities(context);
        }
        public University GetUniversity(string name)
        {
            using (RiverContext context = new RiverContext())
                return universityDAO.GetUniversity(name, context);
        }
        public University GetUniversity(int id)
        {
            using (RiverContext context = new RiverContext())
                return universityDAO.GetUniversity(id, context);
        }


        public void AddUniversity(University university, int universityId, string name, ICollection<Application> applications)
        {
            universityDAO.AddUniversity(university, universityId, name, applications);
        }
        public void AddToCollection(Application application, University university, RiverContext context)
        {
            universityDAO.AddToCollection(application, university, context);
        }
        public List<Application> GetApplications(int id)
        {
            using (RiverContext context = new RiverContext())
            {
                University university = context.Universities.Include(u => u.Applications).FirstOrDefault(u => u.UniversityID.Equals(id));
                return universityDAO.GetApplications(university, context);
            }
        }






    }
}
