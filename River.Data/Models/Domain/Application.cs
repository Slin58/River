using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.Models.Domain
{
    public enum Status
    {
        Pending,
        Rejected,
        Conditional,  //Conditionally Accepted
        Unconditional //Unconditionally Accepted
        
    }


    public class Application
    {
        public int Id { get; set; } 
        public int CourseId { get; set; }
        public int ApplicantId { get; set; }
        public int UniversityId { get; set; }
        public Status Status { get; set; }
        public string InformationToStatus { get; set; }

    }
}
