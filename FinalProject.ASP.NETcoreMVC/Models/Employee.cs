using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace FinalProject.ASP.NETcoreMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter a name")]
        [Range(typeof(String), "a", "z")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a name")]
        [Range(typeof(String), "a", "z")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime),"1/1/1900","5/3/2006")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Please enter a Date")]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime), "1/1/1995", "5/3/2024")]
        public DateTime HireDate { get; set; }

        public int Manager { get; set; }
    }
}
