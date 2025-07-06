
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAdvPro3.Models
{
    public class CarsModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }
        [Range(1, 1000)]
        public int Price { get; set; }
       
        [Required]
        public string Type { get; set; }

        public Boolean ForSale { get; set; }

        public Boolean ForRent { get; set; }



    }
}
