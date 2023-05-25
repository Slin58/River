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

namespace River.Services.Service
{

    public class UserService : IUserService
    {
        IUserDAO userDAO;

        public UserService()
        {
            userDAO = new UserDAO();
        }
        public IList<User> GetUsers()
        {
            using (RiverContext context = new RiverContext())
            {
                return userDAO.GetUsers(context);
            }
        }
            
        public User GetUser(string id)
        {
            using (RiverContext context = new RiverContext())
            {
                return userDAO.GetUser(id, context);
            }    
           
        }

        public void Edit(User user)
        {
            using (RiverContext context=new RiverContext())
            {
                userDAO.Edit(user, context);
                context.SaveChanges();
            }
        }


    }
}
