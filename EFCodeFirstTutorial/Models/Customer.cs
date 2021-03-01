using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstTutorial.Models {
    public class Customer {
        public int Id { get; set; }    //Primary Key
        [StringLength(10), Required]// ATTRIBUTE String length will be 10 char. Required = cannot be null
        public string Code { get; set; } // ATTRIBUTE Must be a unique value
        [StringLength(50), Required]
        public string Name { get; set; }
        public bool IsNational { get; set; }
        [Column(TypeName = "decimal(9,2)")] //ATTRIBUTE
        public decimal Sales { get; set; }
        public DateTime Created { get; set; }

        //add default constructor DO THIS FIRST
        public Customer() { }


    }
}
