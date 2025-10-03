using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweeft_5._0.Models
{
    public class TeacherStudent
    {
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public int PupilID { get; set; }
        public Student Student { get; set; }
    }
}

