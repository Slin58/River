using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using River.Data.Models.Domain;
using River.Data.Models.Repository;
using static System.Net.Mime.MediaTypeNames;

namespace River.Data.IDAO
{
    public interface IUserDAO
    {
        IList<User> GetUsers(RiverContext context);
        User GetUser(string id, RiverContext context);

        void Edit(User user, RiverContext context);
        void AddUser(User user, RiverContext context);
        public List<Models.Domain.Application> GetApplications(User user, RiverContext context);
        void AddToCollection(Models.Domain.Application application, User user, RiverContext context);
    }
}
