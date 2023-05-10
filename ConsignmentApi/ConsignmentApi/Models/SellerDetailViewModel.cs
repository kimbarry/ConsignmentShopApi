namespace ConsignmentApi.Models
{
    public class SellerDetailViewModel
    {
        public int SellerId { get; set; }
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public string? Email { get; set; }
        public bool? IsActive { get; set; }
        public string? CellNum { get; set; }
        public decimal EarnedMoneyToDate { get {
                //TODO: Implement this by calling database and getting sum of all sold items by this seller 
                //TODO: Math the percentage of credit to the seller
                return 0;
            } }
        public string Notes { get; set; }

        public SellerDetailViewModel() { }

        public SellerDetailViewModel(Seller seller)
        {
            SellerId = seller.SellerId;
            FirstName = seller.FirstName;
            LastName = seller.LastName;
            Email = seller.Email;
            IsActive = seller.IsActive;
            CellNum = seller.CellNum;
            Notes = seller.Notes;
        }
    }
}
