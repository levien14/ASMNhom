using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class Person
    {
        [Key]
        [ForeignKey("AccountId")]
        public int AccountId { get; set; }
        public Account Account { get; set; }
        [Required]
        [MaxLength(5)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        public DateTime BOD { get; set; }
        [Required]
        public PersonGender Gender { get; set; }
        [Required]
        public string Avatar { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Address { get; set; }
        public string Description { get; set; }
    }
    public enum PersonGender {
        Other = 0,
        Male = 1,
        FeMale = 2
    }
}
