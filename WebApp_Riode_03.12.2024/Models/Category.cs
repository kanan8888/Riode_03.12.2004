namespace WebApp_Riode_03._12._2024.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public List<Product> Product { get; set; }
    }
}
