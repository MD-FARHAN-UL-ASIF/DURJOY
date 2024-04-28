using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Entities
{
    public class Landlord
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Contact { get; set; }

        public virtual ICollection<Property> Properties { get; set; }
        public virtual ICollection<Agreement> Agreements { get; set; }
    }
}
