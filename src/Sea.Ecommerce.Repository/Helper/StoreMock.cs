using Sea.Ecommerce.Repository.Models;

namespace Sea.Ecommerce.Repository.Helper
{
    public static class StoreMock
    {
        public static List<Store> GetMockStores()
        {
            return new List<Store>
            {
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Tech Superstore",
                    Address = "123 Tech Street",
                    City = "San Francisco",
                    State = "CA",
                    ZipCode = "94107",
                    PhoneNumber = "(415) 555-1234",
                    Email = "contact@techsuperstore.com",
                    OpeningHours = "Mon-Fri 9am - 8pm",
                    ManagerName = "John Doe"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Fashion Outlet",
                    Address = "456 Fashion Blvd",
                    City = "New York",
                    State = "NY",
                    ZipCode = "10001",
                    PhoneNumber = "(212) 555-5678",
                    Email = "info@fashionoutlet.com",
                    OpeningHours = "Mon-Sun 10am - 9pm",
                    ManagerName = "Jane Smith"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Grocery Plus",
                    Address = "789 Market Street",
                    City = "Austin",
                    State = "TX",
                    ZipCode = "73301",
                    PhoneNumber = "(512) 555-9012",
                    Email = "support@groceryplus.com",
                    OpeningHours = "Mon-Sun 6am - 11pm",
                    ManagerName = "Mike Johnson"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Books & More",
                    Address = "101 Book Lane",
                    City = "Seattle",
                    State = "WA",
                    ZipCode = "98101",
                    PhoneNumber = "(206) 555-3456",
                    Email = "help@booksandmore.com",
                    OpeningHours = "Mon-Sat 9am - 6pm",
                    ManagerName = "Emily Clark"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Home Essentials",
                    Address = "987 Home Ave",
                    City = "Chicago",
                    State = "IL",
                    ZipCode = "60601",
                    PhoneNumber = "(312) 555-7890",
                    Email = "service@homeessentials.com",
                    OpeningHours = "Mon-Sun 8am - 8pm",
                    ManagerName = "David Brown"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Pet Paradise",
                    Address = "234 Pet Street",
                    City = "Miami",
                    State = "FL",
                    ZipCode = "33101",
                    PhoneNumber = "(305) 555-6789",
                    Email = "contact@petparadise.com",
                    OpeningHours = "Mon-Sat 9am - 7pm",
                    ManagerName = "Sara Lee"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Electronics World",
                    Address = "654 Tech Plaza",
                    City = "Los Angeles",
                    State = "CA",
                    ZipCode = "90001",
                    PhoneNumber = "(213) 555-0123",
                    Email = "support@electronicsworld.com",
                    OpeningHours = "Mon-Sun 10am - 10pm",
                    ManagerName = "Chris Evans"
                },
                new Store
                {
                    Id = Guid.NewGuid(),
                    StoreName = "Healthy Living",
                    Address = "321 Wellness Blvd",
                    City = "Denver",
                    State = "CO",
                    ZipCode = "80201",
                    PhoneNumber = "(303) 555-4567",
                    Email = "info@healthyliving.com",
                    OpeningHours = "Mon-Fri 7am - 7pm",
                    ManagerName = "Linda Green"
                }
            };
        }
    }
}
