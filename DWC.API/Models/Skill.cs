using System;
using System.ComponentModel.DataAnnotations;

namespace DWC.API.Models
{
    public class Skill
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Description { get; set; }
        public bool Enabled { get; set; }
    }
}
