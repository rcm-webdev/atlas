using System.ComponentModel.DataAnnotations;

namespace atlas.Models
{
    public class Agent
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = null!;

    }
}
