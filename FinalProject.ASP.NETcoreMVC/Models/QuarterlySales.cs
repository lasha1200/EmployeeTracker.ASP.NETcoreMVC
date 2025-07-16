using System.ComponentModel.DataAnnotations;

namespace FinalProject.ASP.NETcoreMVC.Models
{
    public class QuarterlySales
    {
        
        public int Id {  get; set; }

        public string Employee { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a year")]
        [Range(2000,2024)]
        public int Year {  get; set; }

        [Required(ErrorMessage = "Please quarter")]
        [Range(1,4)]
        public int Quarter {  get; set; }

        [Required(ErrorMessage = "Please enter amount")]
        [Range(0,1000000)]
        public double Amount { get; set; }

    }
}
