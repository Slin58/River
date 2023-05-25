using Microsoft.EntityFrameworkCore;
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
    public class UniversityDAO : IUniversityDAO
    {

        //getUniversities
        public IList<University> GetUniversities(RiverContext context)
        {
            return context.Universities.ToList();
        }


        //getUniversity
        public University GetUniversity(int id, RiverContext context)
        {
            return context.Universities.Find(id);
        }

        //addUniversity
        public void AddUniversity(University university, int universityId, string name, ICollection<Application> applications)
        {
            using(var context = new RiverContext())
            {
                university.UniversityID = universityId;
                university.Name = name;
                university.Applications = applications;

                context.Universities.Add(university);
                context.SaveChanges();

            }
        }

        
        

        
        


        
        


    }
}
