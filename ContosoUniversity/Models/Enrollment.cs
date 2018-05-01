using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        //ok to use either pattern, classNameID or ID -- should pick one for project for consistency

        public int CourseID { get; set; }
        //foreign key -- corresponding navigation property is Course
        //One Enrollment - One Course

        public int StudentID { get; set; }
        //foreign key -- corresponding navigation property is Student

        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }

        public Student Student { get; set; }


    }
}
