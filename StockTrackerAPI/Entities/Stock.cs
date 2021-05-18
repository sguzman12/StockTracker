using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockTrackerAPI.Entities
{
    public class Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a valid alpha code.")]
        [MaxLength(6)]
        public string AlphaCode { get; set; }

        [Required(ErrorMessage = "Please provide a stock name.")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$",
           ErrorMessage = "Please provide value in the proper format (#.##)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^\$?\d+(\.(\d{2}))?$",
           ErrorMessage = "Please provide value in the proper format (#.##)")]
        public decimal closingPrice { get; set; }

        public string url { get; set; }
    }
}
