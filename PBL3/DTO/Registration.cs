using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PBL3.DTO
{
    public class Registration
    {
        [Key]
        [StringLength(10)]
        [Required]
        public string regisId { get; set; }
        public string CMND_CCCD { get; set; }
        public int Dose { get; set; }
        public string vaccineName { get; set; }        
        public DateTime regisDay { get; set; }
        public bool State { get; set; }

        [ForeignKey("CMND_CCCD")]
        public virtual Citizen Citizen { get; set; }
    }
}
