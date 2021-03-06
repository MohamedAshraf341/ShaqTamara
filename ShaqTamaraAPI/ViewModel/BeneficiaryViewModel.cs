using System.ComponentModel.DataAnnotations;

namespace ShaqTamaraAPI.ViewModel
{
    public class BeneficiaryViewModel
    {
        [Required, StringLength(100)]
        public string FirstName { get; set; }

        [Required, StringLength(100)]
        public string LastName { get; set; }
        public string Password { get; set; }
        [Required(ErrorMessage = "Phone is required"), StringLength(100)]
        public string PhoneNumber { get; set; }
        public string Phone2 { get; set; }

        [Required(ErrorMessage = "Password is required"), StringLength(256)]
        public string Address { get; set; }
        public string latitudes { get; set; }
        public string longitudes { get; set; }
        public string Governorate { get; set; }
        public string DonationRate { get; set; }
        public string DonationNumber { get; set; }

    }
}
