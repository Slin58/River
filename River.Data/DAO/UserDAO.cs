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
    public class UserDAO : IUserDAO
    {
        public IList<User> GetUsers(RiverContext context)
        {
            
            return context.Users.ToList();
        }
        public User GetUser(string id, RiverContext context)//Get profile
        {
            return context.Users.Find(id);
        }


    }
}
