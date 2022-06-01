using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    public class Account
    {
        [Key]
        [StringLength(50)]
        [Required]
        public string Username { get; set; }
        public string Fullname { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public bool Permission { get; set; }
    }
}
