using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Citizen
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string CMND_CCCD { get; set; }
        public string fullName { get; set; }
        public bool gender { get; set; }
        public DateTime birth { get; set; }
        [StringLength(50)]
        public string phone { get; set; }
        public string address { get; set; }
        public DateTime regisDay { get; set; }
        public int vaccination { get; set; }

    }
}
