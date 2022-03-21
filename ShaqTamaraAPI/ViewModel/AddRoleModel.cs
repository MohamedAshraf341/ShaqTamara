using System.ComponentModel.DataAnnotations;

namespace ShaqTamaraAPI.ViewModel
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string Role { get; set; }
    }
}
