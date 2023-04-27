namespace ConsignmentApi.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
        public string? CellNum { get; set; }
        public IEnumerable<Item> ItemsList { get; set; }
    }
}
