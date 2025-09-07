using System.ComponentModel.DataAnnotations;

namespace crud_opration.Models
{
    public class Student
    {
        [Key]
        [Display(Name="Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        
        [Display(Name = "Student Id")]
        public string Email { get; set; }

        public string Course { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

    }
}
