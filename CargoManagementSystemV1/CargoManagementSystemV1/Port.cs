using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CargoManagementSystemV1
{
    public class Port
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public string City { get; set; }

        public string MyProperty { get; set; }

        public string District { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }

    }
}
