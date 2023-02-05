using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CargoManagementSystemV1
{
    public class Shipper
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        public string City { get; set; }

        public string MyProperty { get; set; }

        public string District { get; set; }

        public string Address { get; set; }

        public int Phone { get; set; }

        public string Email { get; set; }
    }
}
