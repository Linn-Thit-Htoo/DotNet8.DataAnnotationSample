using System.ComponentModel.DataAnnotations;

namespace DotNet8.DataAnnotationSample.Models
{
    public class ProductModel
    {
        public long ProductId { get; set; }

        [Length(5, 10)]
        public required string ProductName { get; set; }
        public decimal Price { get; set; }

        [AllowedValues("Computer", "Mobile", "Beauty")]
        public string Category { get; set; }

        [DeniedValues("Printers")]
        public string SubCategory { get; set; }

    }
}
