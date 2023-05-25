using River.Data.DAO;
using River.Data.Models.Domain;
using River.Data.Models.Repository;
using River.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Services.Service
{
    public class ApplicationService : IApplicationService
    {
        UserDAO userDAO;
        ApplicationDAO applicationDAO;
        UniversityDAO universityDAO;

        public ApplicationService()
        {
            userDAO = new UserDAO();
            applicationDAO = new ApplicationDAO(); 
            universityDAO = new UniversityDAO();
        }

        public Application GetApplication (int id)
        {
            using (RiverContext context = new RiverContext())
            {
                Application application = context.Applications.Find(id);
                return applicationDAO.GetApplication(application, context);
            }

        }
        public bool AddApplication (Application application, String userId, int universityId)
        {
            try
            {
                using (RiverContext context = new RiverContext())
                {
                    applicationDAO.AddApplication(application, context);
                    User user = userDAO.GetUser(userId.ToString(), context);
                    userDAO.AddToCollection(application, user, context);
                    University university = universityDAO.GetUniversity(universityId, context);
                    universityDAO.AddToCollection(application, university, context);
                    context.SaveChanges();
                }

                return true;
            }
            catch
            {
                return false;
            }


        }
    }
}
