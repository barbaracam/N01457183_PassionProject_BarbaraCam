using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAmigoPet.Models
{
    public class Pet
    {
        [Key]
        public int PetID { get; set; }

        public string PetName { get; set; }
        public int PetAge { get; set; }
        public string PetBreed { get; set; }
        public string PetTips { get; set; }

        //Foreign keys in Entity Framework
        /// https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx

        //A pet has one customer
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
    }
    //This class can be used to transfer information about a pet.
    //also known as a "Data Transfer Object"
    //https://docs.microsoft.com/en-us/aspnet/web-api/overview/data/using-web-api-with-entity-framework/part-5
    //You can think of this class as the 'Model' that was used in 5101.
    //It is simply a vessel of communication
    public class PetDto
    {
        public int PetID { get; set; }
        public string PetName { get; set; }
        public string PetBio { get; set; }


    }

}