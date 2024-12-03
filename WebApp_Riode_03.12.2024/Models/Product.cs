namespace WebApp_Riode_03._12._2024.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int? OldPrice { get; set; }
        public int ImageUrl { get; set; }
        public IFormFile File { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
