namespace ConsignmentApi.Models
{
    public class SellerUpdateDto
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountToCredit { get; set; }
        public string Email { get; set; }
        public string CellNum { get; set; }
        public bool IsActive { get; set; }
        public string Notes { get; set; }
    }
}
