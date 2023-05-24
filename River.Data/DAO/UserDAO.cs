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
        public User GetUser(int id, RiverContext context)
        {
            return context.Users.Find(id);
        }


    }
}
