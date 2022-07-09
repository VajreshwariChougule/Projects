using System.ComponentModel.DataAnnotations;
namespace MiniProject.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }

        [DataType(DataType.Currency)]
        public double? Price { get; set; }

        public string Brand { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0 : yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string ManufactureDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-mm-dd}", ApplyFormatInEditMode = true)]
        public string ExpirationDate { get; set; }
    }
}
