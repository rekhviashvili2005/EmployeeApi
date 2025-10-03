using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_5._0.Models
{
    public class Student
    {
        [Key]
        public int PupilID { get; set; }  
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }

        public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();

      
    }
}
