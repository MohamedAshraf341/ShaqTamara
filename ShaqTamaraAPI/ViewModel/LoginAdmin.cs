using System.ComponentModel.DataAnnotations;

namespace ShaqTamaraAPI.ViewModel
{
    public class LoginAdmin
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
