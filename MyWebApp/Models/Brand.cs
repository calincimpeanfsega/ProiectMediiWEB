namespace MyWebApp.Models
{
    public class Brand
    {
        public int ID { get; set; }
        public string BrandName { get; set; }
        public ICollection<Brand> Brands { get;set; } 

    }
}
