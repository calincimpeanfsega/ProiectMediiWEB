using System.ComponentModel.DataAnnotations;

namespace MyWebApp.Models
{
    public class Buying
    {
        public int ID { get; set; }
        public int? ClientID { get; set; }
        public Client? Client { get; set; }
        public int? ProductID { get; set; }
        public Product? Product { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
    }
}
