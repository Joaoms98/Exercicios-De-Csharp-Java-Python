using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Steam.src.models
{
    [Table("tb_Library")]
    public class LibraryModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string IdLibrary { get; set; }

        [ForeignKey("Fk_user")]
        public UserModel User { get; set; }

        [ForeignKey("Fk_Game")]
        public LibraryModel Library { get; set; }

    }
}
