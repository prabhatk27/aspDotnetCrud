using System.ComponentModel.DataAnnotations;

namespace StudentProject.Models
{
    public class Student
    {
        [Key]
        public int id { get; set; }    // shortcut prop

        [Required]
        [Display(Name = "Student Name")]
        public string name { get; set; }

        [Required]
        [Display(Name = "Course")]
        public string course { get; set; }
       
        [Required]
        [Display(Name = "Course Duration")]
        public int duration { get; set; }

    }
}
