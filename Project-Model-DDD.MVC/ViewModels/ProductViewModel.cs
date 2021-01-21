using System;
using System.ComponentModel.DataAnnotations;

namespace Project_Model_DDD.MVC.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field is required")]
        [MaxLength(100, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(2, ErrorMessage = "Min Length is {0} characters")]
        public string Name { get; set; }

        [MaxLength(13, ErrorMessage = "Max Length is {0} characters")]
        [MinLength(13, ErrorMessage = "Min Length is {0} characters")]
        public string BarCode { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999999999")]
        [Required(ErrorMessage = "The field is required")]
        public decimal Price { get; set; }

        [Range(0, 99999999999)]
        [Required(ErrorMessage = "The field is required")]
        public int Stock { get; set; }

        [ScaffoldColumn(false)]
        public DateTime RegistrationDate { get; set; }

        [Display(Description = "Is Active?")]
        public bool IsActive { get; set; }
    }
}