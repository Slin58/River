using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.Models.Domain
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public List<Application> Applications { get; set; }


        //editProfile
        //getApplications
        //addApplication
        //editApplication
        //deleteApplication

    }
}
