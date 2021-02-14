using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAmigoPet.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentID { get; set; }

        public DateTime AppointmentDay { get; set; }

        public string AppointmentNote { get; set; }


        //Utilizes the inverse property to specify the "Many"
        //https://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx
        
        //One Appointment many pets
        public ICollection<Pet> Pets { get; set; }

    }
}