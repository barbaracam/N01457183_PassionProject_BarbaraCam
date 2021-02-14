using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAmigoPet.Models
{
    public class PetWalker
    {
        [Key]
        public int PetWalkerID { get; set; }

        public string Experience { get; set; }

        public string PetWalkerBio { get; set; }


        //Utilizes the inverse property to specify the "Many"
        //https://www.entityframeworktutorial.net/code-first/inverseproperty-dataannotations-attribute-in-code-first.aspx

        //One PetWalker can have many appointments
        public ICollection<Pet> Pets { get; set; }

    }
}