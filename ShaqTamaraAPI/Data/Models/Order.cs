using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShaqTamaraAPI.Data.Models
{
    public class Order
    {

        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Hour { get; set; }
        public string NumberOfMale { get; set; }
        public string Address { get; set; }
        public ApplicationUser applicationUser { get; set; }
        [MaxLength(450)]
        public string applicationUserId { get; set; }
    }

}
