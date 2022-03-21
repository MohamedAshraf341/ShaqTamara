using System.ComponentModel.DataAnnotations;

namespace ShaqTamaraAPI.ViewModel
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Phone is required")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
