using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ContosoUniversity.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //code will enter this, not the DB [???]
        [Display(Name = "Number")]
        public int CourseID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [Range(0, 5)]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public Department Department {get; set;}


        public ICollection<Enrollment> Enrollments { get; set; }
        //Enrollments is a navigation property
        //A Course can be related to many Enrollments entities
        public ICollection<CourseAssigment> CourseAssigments { get; set; }

    }
}
