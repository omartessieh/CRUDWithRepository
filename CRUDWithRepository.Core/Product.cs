﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWithRepository.Core
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Product Name")]
        public string ProductName { get; set; }

        [Required]
        [DisplayName("Price")]
        public decimal Price { get; set; }

        [Required]
        [DisplayName("Qty")]
        public int Qty { get; set; }
    }
}
