namespace ConsignmentApi.Models
{
    public class Seller
    {
        public int SellerId { get; set; }
        
        public string FirstName { get; set; }
        public string? LastName { get; set;  }
        public string Name {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
        public string? CellNum { get; set; }
        public IEnumerable<Item> ItemsList { get; set; }
        public string Notes { get; set; }

    }
}
