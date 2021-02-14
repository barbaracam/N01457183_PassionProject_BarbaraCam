using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAmigoPet.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerPhone { get; set; }

        //A Customer can have many pets
        public ICollection<Pet> Pets { get; set; }

        //A customer can have many appointments
        public ICollection<Appointment> Appointments { get; set; }
                        
    }
}