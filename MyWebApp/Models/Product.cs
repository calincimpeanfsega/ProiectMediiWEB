using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyWebApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Display(Name = "Product")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
       public int? BrandID { get; set; }
        public Brand? Brand { get; set; }
        public Admin? Admin { get; set; }
        public ICollection<ProductCategory>? ProductCategories { get; set; }

    }
}
