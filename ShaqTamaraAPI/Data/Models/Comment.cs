using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShaqTamaraAPI.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string CommentDate { get; set; }
        public string Content { get; set; }
        public ApplicationUser applicationUser { get; set; }
        [MaxLength(450)]
        public string applicationUserId { get; set; }
        public Post Post { get; set; }

        public int PostId { get; set; }

    }

}
