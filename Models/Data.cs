using System;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Data
    {
        public Data() : base()
        {
            Guid.NewGuid();
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter Email")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Please enter correct email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Age")]
        [Display(Name = "Age")]
        [Range(18, 120, ErrorMessage = "Age +18")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Enter Salary")]
        [Display(Name = "Salary")]
        [Range(3000, 10000000, ErrorMessage = "Salary must be between 3000 and 10000000")]
        public int Salary { get; set; }

    }
}
