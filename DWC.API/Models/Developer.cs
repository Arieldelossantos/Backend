using System;
using System.ComponentModel.DataAnnotations;
namespace DWC.API.Models
{
    public class Developer
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Initials { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public string Skills { get; set; }      
        public string Webpage { get; set; }    
        public string LinkedIn { get; set; }     
        public string Twitter { get; set; }
        public string Github { get; set; }
        public DateTime MemberSince { get; set; }
        public bool Enabled { get; set; }
    }
}
