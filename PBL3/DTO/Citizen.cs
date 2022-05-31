using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Citizen
    {
        [Key]
        [StringLength(20)]
        [Required]
        public string CMND { get; set; }
        public string Fullname { get; set; }
        public bool Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
      
       
        //public List<string> Vaccination { get; set; }
    }
}
