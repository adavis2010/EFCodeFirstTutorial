using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstTutorial {
    public class Item {
        

        public int Id { get; set; }
        [StringLength(50), Required] // Attribute
        public string Name { get; set; }
        [Column(TypeName = "decimal (9,2)")] //Attribute
        public decimal Price { get; set; }




        public Item() { }// default constructor

    }
}
