namespace ConsignmentApi.Models
{
    public class SellersListViewModel
    {
        public int SellerId { get; set; }
        public string Name { get; set; }

        public SellersListViewModel() { }
        public SellersListViewModel(Seller seller)
        {
            SellerId = seller.SellerId;
            Name = seller.Name;
        }
    }
}
