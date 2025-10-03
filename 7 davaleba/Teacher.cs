using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_5._0.Models
{
    public class Teacher
    {
        public int TeacherID { get; set; }   // PK
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }

        // Navigation property (many-to-many)
        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
    }
}
