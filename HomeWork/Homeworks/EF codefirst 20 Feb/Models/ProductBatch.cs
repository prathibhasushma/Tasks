using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_codefirst_20_Feb.Models
{
    internal class ProductBatch
    {
        [Key]
        public int Batchid { get; set; }
        [Required]
        [StringLength(50)]
        public string? description { get; set; }
        public double price { get; set; }

        public int quantity { get; set; }

        [ForeignKey("ProductId")]
        public Product? Product { get; set; }






    }
}
