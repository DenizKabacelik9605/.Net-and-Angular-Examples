using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CargoManagementSystemV1
{
    public class ShippedAt
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CargoId { get; set; }

        public DateTime DispatchDate { get; set; }

        public DateTime ShippedDate { get; set; }


    }
}
