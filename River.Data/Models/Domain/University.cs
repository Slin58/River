using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace River.Data.Models.Domain
{
    public class University
    {
        
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Application> Applications { get; set; }
    }
}
