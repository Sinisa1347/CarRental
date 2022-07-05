using System.ComponentModel.DataAnnotations;

namespace CarRentalWeb.Pages.Model
{
    public class Category
    {
        [Key]
        [Display(Name ="Car ID")]
        public int CarId { get; set; }

        [Required]
        [Display(Name ="Car model")]
        public string CarModel { get; set; }

        [Required]
        [Display(Name = "Car color")]
        public string CarColor { get; set; }


        [Required]
        [Range(1990,2022,ErrorMessage ="Car age must be beetwen 1990 and 2022")]
        [Display(Name ="Car age")]
        public int CarAge { get; set; }

        [Required]
        [Range(0,400000,ErrorMessage ="Kilometres in the car must be beetwen 0 and 400 000")]
        [Display(Name = "Kilometres in a car")]
        public int CarKilometres { get; set; }


    }
}
