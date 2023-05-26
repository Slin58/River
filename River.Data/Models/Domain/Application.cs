using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.Models.Domain
{


    public class Application
    {
        public int Id { get; set; } 
        public string UniversityName { get; set; }
        public int CourseId { get; set; }
        public string Statement { get; set; }
        public string TeacherContact { get; set; }
        public string TeacherReference { get; set; }
        public string Offer { get; set; }
        public bool Firm { get; set; }

    }
}
