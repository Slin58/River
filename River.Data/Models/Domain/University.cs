using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.Models.Domain
{
    public class University
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Website { get; set; }
        public List<Course> Courses { get; set; }
    }
}
