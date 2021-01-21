using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Model_DDD.MVC.ViewModels
{
    public class ClientViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [MaxLength(100, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(2, ErrorMessage = "Min Length is {0} characters")]
        public string Name { get; set; }

        [MaxLength(100, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(2, ErrorMessage = "Min Length is {0} characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [MaxLength(14, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(14, ErrorMessage = "Min Length is {0} characters")]
        public string CellNumber { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [EmailAddress(ErrorMessage = "Email is not valid")]
        [Display(Description = "E-mail")]
        public string Email { get; set; }

        [MaxLength(100, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(2, ErrorMessage = "Min Length is {0} characters")]
        public string Address { get; set; }

        [MaxLength(100, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(2, ErrorMessage = "Min Length is {0} characters")]
        public string City { get; set; }

        [MaxLength(50, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(2, ErrorMessage = "Min Length is {0} characters")]
        public string State { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        [Display(Description = "Is Active?")]
        public bool IsActive { get; set; }
    }
}