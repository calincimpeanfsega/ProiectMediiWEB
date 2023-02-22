using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MyWebApp.Models
{
    public class Admin
    {
        public int AdminID { get; set; }

        [Display(Name = "Future Sales")]
        public string Name { get; set; }

        [Display(Name = "Discount")]
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
