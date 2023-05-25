using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.Models.Domain
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        [AllowNull]
        public string Adress { get; set; }
        [AllowNull]
        public string Telefon { get; set; }
        public string Email { get; set; }
        [AllowNull]
        public List<Application> Applications { get; set; }


        //editProfile
        //showDetails

        //getApplications
        //addApplication
        //editApplication
        //deleteApplication

    }
}
