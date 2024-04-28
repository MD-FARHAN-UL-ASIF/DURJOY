using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Entities
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Landlord")]
        public int LandlordId { get; set; }
        public virtual Landlord Landlord { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
