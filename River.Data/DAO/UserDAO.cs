using Microsoft.EntityFrameworkCore;
using River.Data.IDAO;
using River.Data.Models.Domain;
using River.Data.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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

        public void Edit(User user, RiverContext context)
        {
            User u =context.Users.Find(user.Id);
            context.Entry(u).CurrentValues.SetValues(u);
        }
        public void AddUser(User user, RiverContext context)
        {
            context.Users.Add(user);
        }

        public List<Application> GetApplications (User user, RiverContext context)
        {
            return context.Users.Find(user.Id).Applications.ToList();
        }
        public void AddToCollection(Application application, User user, RiverContext context)
        {
            context.Users.Include(u => u.Applications).FirstOrDefault(u => u.Id.Equals(user.Id)).Applications.Add(application);

        }
    }
}
