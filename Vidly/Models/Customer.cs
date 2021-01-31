using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required] //not null
        [StringLength(255)] //string
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }
        
        public MembershipType MembershipType { get; set; } //FK

        [Display(Name = "Type Of MemberShip")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Customer date of birth")]
        public DateTime? DateOfBirth { get; set; }
    }
}
