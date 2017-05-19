using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace app.domain.artiste
{
    public class Artiste
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_ARTISTE { get; set; }

        [Required]
        public string NOM_ARTISTE { get; set; }

        [Required]
        public string PRENOM_ARTISTE { get; set; }

        [Required]
        public string TELEPHONE { get; set; }
        
        public string NOM_DE_SCENE { get; set; }

        [Unique]
        [Required]
        public long NAS { get; set; }
    }
}
