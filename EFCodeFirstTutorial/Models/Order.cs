﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCodeFirstTutorial.Models {
    public class Order {
        public int Id { get; set; }
        [StringLength(200), Required]   //Attributes
        public string Description { get; set; }
        [StringLength(12), Required]    //Attributes
        public string Status { get; set; } = "NEW";
        [Column(TypeName = "decimal (9,2)")]    //Attribute
        public decimal Total { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }







        //Default constrructor
        public Order() { }
    }
}
