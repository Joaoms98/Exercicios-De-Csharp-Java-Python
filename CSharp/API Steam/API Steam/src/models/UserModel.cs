using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Steam.src.models
{
    [Table("tb_User")]
    public class UserModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Required,StringLength(10)]
        public string Username { get; set; }

        [Required,StringLength (12)]
        public string Password { get; set; }

        [Required,StringLength(30)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Resume { get; set; }

        [Required,StringLength(30)]
        public string Nationality { get; set; }

        [Required]
        public int Level { get; set; }

        public string Picture { get; set; }

    }
}
