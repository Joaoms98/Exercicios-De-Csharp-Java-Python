using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace API_Steam.src.models
{
    [Table("tb_Game")]
    public class GameModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDGame { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required, StringLength(30)]
        public int ReleaseDate { get; set; }

        [Required,StringLength(10)]
        public string Categoria { get; set; }
       
        [Required]
        public double Price { get;set; }
    }
}
