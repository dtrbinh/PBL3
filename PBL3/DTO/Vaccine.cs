using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Vaccine
    {
        [Key]
        [StringLength(30)]
        [Required]
        public string VaccineName { get; set; }
        public int Quantity { get; set; }
    }
}
