using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagementSystemV1
{
    public class Cargo
    {

        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public string Sales { get; set; }

        [Required]
        public string Package { get; set; }

        [Required]
        public int Weight { get; set; }

        [Required]
        public int Height { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        public string Order { get; set; }




    }
}
