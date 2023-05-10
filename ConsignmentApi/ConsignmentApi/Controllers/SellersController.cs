using ConsignmentApi.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ConsignmentApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class SellersController : ControllerBase
    {
        public List<Seller> TempDataStore { get; set; }
        public SellersController()
        {
            TempDataStore = new List<Seller> {
                new Seller {
                    SellerId = 1,
                    FirstName = "Seller 1",
                    LastName = "",
                    AccountToCredit = "Smith",
                    Email = "test@test.com",
                    IsActive = true,
                    CellNum = "555-555-5555",
                    ItemsList = new Item[] {
                        new Item { Id = 1, SellerId = 1, Name = "Item 1", Description = "Item 1 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                        new Item { Id = 2, SellerId = 1, Name = "Item 2", Description = "Item 2 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                        new Item { Id = 3, SellerId = 1, Name = "Item 3", Description = "Item 3 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) }
                    },
                    Notes = ""
                },
                new Seller {
                    SellerId = 2,
                    FirstName = "Seller 2",
                    LastName = "",
                    AccountToCredit = "Baker",
                    Email = "test2@test.com",
                    IsActive = true,
                    CellNum = "222-555-5555",
                    ItemsList = new  Item[]
                    {
                        new Item { Id = 1, SellerId = 2, Name = "Item 4", Description = "Item 4 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                        new Item { Id = 2, SellerId = 2, Name = "Item 5", Description = "Item 5 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                        new Item { Id = 3, SellerId = 2, Name = "Item 6", Description = "Item 6 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) }
                    },
                    Notes = ""
                },
                //Create one lk.inactive sellers with inactive items
                new Seller
                {
                    SellerId = 3,
                    FirstName = "Seller 3",
                    LastName = "",
                    AccountToCredit = "Williams",
                    Email = "test3@test.com",
                    IsActive = false,
                    CellNum = "222-555-5555",
                    ItemsList = new  Item[]
                    {
                    },
                    Notes = ""
                }
            };
        }
        // GET: api/<SellersController>
        [HttpGet]
        public IEnumerable<SellersListViewModel> GetAllSellers()
        {
            return new SellersListViewModel[] {
                new SellersListViewModel {
                    SellerId = 1,
                    Name = "Seller 1"
                    //Email = "test@test.com",
                    //IsActive = true,
                    //CellNum = "555-555-5555",
                    //ItemsList = new Item[] {
                    //    new Item { Id = 1, SellerId = 1, Name = "Item 1", Description = "Item 1 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                    //    new Item { Id = 2, SellerId = 1, Name = "Item 2", Description = "Item 2 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                    //    new Item { Id = 3, SellerId = 1, Name = "Item 3", Description = "Item 3 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) }
                    //},
                },
                new SellersListViewModel {
                    SellerId = 2,
                    Name = "Seller 2"
                    //Email = "test2@test.com",
                    //IsActive = true,
                    //CellNum = "222-555-5555",
                    //ItemsList = new  Item[]
                    //{
                    //    new Item { Id = 1, SellerId = 2, Name = "Item 4", Description = "Item 4 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                    //    new Item { Id = 2, SellerId = 2, Name = "Item 5", Description = "Item 5 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) },
                    //    new Item { Id = 3, SellerId = 2, Name = "Item 6", Description = "Item 6 Description", ImageUrl = "https://via.placeholder.com/150", Size = "M", IsSold = false, Price = 10.00M, ListDate = new DateTime(2021, 1, 1), SaleDate = new DateTime(2021, 1, 1) }
                    //}
                },
                //Create two inactive sellers with inactive items


            }; 
        }
        // GET: api/<SellersController>/{isActive}
        [HttpGet("byActive/{isActive}")]
        public IEnumerable<SellersListViewModel> GetSellersByActive(bool isActive)
        {
           


            return TempDataStore.Where(s => s.IsActive == isActive).Select(s => new SellersListViewModel(s));
        }
       
        [HttpGet("{id}")]
        public SellerDetailViewModel GetSellerById(int id)
        {
            return new SellerDetailViewModel(TempDataStore.FirstOrDefault(s => s.SellerId == id));
        }
        //#TODO: Add null handling

        [HttpGet("name/{name}")]
        public IEnumerable<SellersListViewModel> GetSellerByName(string name)
        {
            return TempDataStore.Where(s => s.Name.Contains(name)).Select(s => new SellersListViewModel(s));
        }
        
        // POST api/<SellersController>
        [HttpPost]
        public void CreateNewSeller([FromBody] SellerCreationDto values)
        {
            int nextId = TempDataStore.Max(s => s.SellerId) + 1;
            Seller sellerToAdd = new Seller()
            {
                
                SellerId = nextId,
                FirstName = values.FirstName,
                LastName = values.LastName,
                AccountToCredit = values.AccountToCredit,
                Email = values.Email,
                IsActive = true,
                CellNum = values.CellNum,
                ItemsList = new List<Item>()
               
            };
            TempDataStore.Add(sellerToAdd);
        }

        // PUT api/<SellersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SellersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            TempDataStore.Remove(TempDataStore.FirstOrDefault(s => s.SellerId == id));
         
        }
    }
}
