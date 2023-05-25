using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Services.Models
{
    public class ApplicationUniversity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string Statement { get; set; }
        public string TeacherContact { get; set; }
        public string TeacherReference { get; set; }
        public string Offer { get; set; }
        public bool Firm { get; set; }
        public int UniversityId { get; set; }
    }
}
