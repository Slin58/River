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
using System.Diagnostics.CodeAnalysis;

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

                User existingUser = context.Users.Find(user.Id);
                existingUser.Name = user.Name;
                existingUser.Adress = user.Adress;
                existingUser.Telefon = user.Telefon;

                userDAO.Edit(existingUser, context);
                context.SaveChanges();
            }
        }
        public void AddUser(User user)
        {
            using (RiverContext context = new RiverContext())
            {
                userDAO.AddUser(user, context);
                context.SaveChanges();
            }
                
        }
        public List<Application> GetApplications(string userId)
        {
            using (RiverContext context = new RiverContext())
            {
                Console.WriteLine("Test123:", userId);
                User user = context.Users.Include(u => u.Applications).FirstOrDefault(u => u.Id.Equals(userId));
                return userDAO.GetApplications(user, context);
            }
        }



    }
}
