namespace ConsignmentApi.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string ImageUrl { get; set; }
        public string Size { get; set; }
        public bool IsSold { get; set; }
        public decimal Price { get; set; }
        public DateTime ListDate { get; set; }
        public DateTime SaleDate { get; set; }   
    }
}