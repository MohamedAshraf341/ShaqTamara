using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ShaqTamaraAPI.Data.Models
{
    public class ApplicationUser : IdentityUser
    {

        [MaxLength(100)]
        public string Category { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }
        public string Address { get; set; }
        [MaxLength(256)]
        public string latitudes { get; set; }
        [MaxLength(256)]
        public string longitudes { get; set; }

        [MaxLength(100)]
        public string Governorate { get; set; }
        [MaxLength(100)]
        public string DonationRate { get; set; }
        [MaxLength(100)]
        public string DonationNumber { get; set; }
        [MaxLength(100)]
        public string vehicle { get; set; }
        public byte[] ProfilePicture { get; set; }




    }

}
